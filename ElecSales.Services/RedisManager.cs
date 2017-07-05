using System;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace ElecSales.Services
{
    public class RedisManager
    {
        ///TODO 缓存Key:自己设定非重复的Key健,Key健设定必须唯一.
        public class KeyParser
        {
            private const string RootKey = "mvcProject_";

            public string GetEmail(string email)
            {
                return $"{RootKey}_Email_{email}";
            }
        }

        #region Redis Tools
        private static KeyParser KeyParserObject { get; } = new KeyParser();

        public static bool Remove(string key)
        {
            var db = Manager.GetDatabase();
            return db.KeyDelete(key);
        }

        public static string Get(string key)
        {
            var db = Manager.GetDatabase();
            return db.StringGet(key);
        }
        public static string Get(Func<KeyParser, string> keyGenerator)
        {
            var db = Manager.GetDatabase();
            var key = keyGenerator(KeyParserObject);
            return db.StringGet(key);
        }

        public static T Get<T>(Func<KeyParser, string> keyGenerator) where T : class
        {
            var db = Manager.GetDatabase();
            var key = keyGenerator(KeyParserObject);
            var ret = db.StringGet(key);
            if (ret.IsNullOrEmpty)
                return null;
            try
            {
                return JsonConvert.DeserializeObject<T>(ret);
            }
            catch
            {
                return null;
            }
        }

        public static int GetInt(Func<KeyParser, string> keyGenerator)
        {
            var db = Manager.GetDatabase();
            var key = keyGenerator(KeyParserObject);
            var ret = db.StringGet(key);
            if (ret.IsNullOrEmpty)
                return 0;
            int val;
            ret.TryParse(out val);
            return val;
        }
        public static bool Set<T>(Func<KeyParser, string> keyGenerator, T value, TimeSpan? timeSpan = null)
        {
            return Set(keyGenerator(KeyParserObject), JsonConvert.SerializeObject(value), timeSpan);
        }
        public static bool Set(Func<KeyParser, string> keyGenerator, string value, TimeSpan? timeSpan = null)
        {
            return Set(keyGenerator(KeyParserObject), value, timeSpan);
        }

        public static bool Set(string key, string value, TimeSpan? timeSpan = null)
        {
            var db = Manager.GetDatabase();
            if (timeSpan.HasValue)
            {
                db.StringSet(key, value, timeSpan);
            }
            else
            {
                db.StringSet(key, value);
            }
            return db.StringSet(key, value);
        }

        public static long Increment(Func<KeyParser, string> keyGenerator)
        {
            var key = keyGenerator(KeyParserObject);
            var db = Manager.GetDatabase();
            var ret = db.StringIncrement(key);
            if (ret == 1)
            {
                db.KeyExpire(key, DateTime.Now.AddDays(2));
            }
            return ret;
        }

        public static bool HasKey(string key)
        {
            var db = Manager.GetDatabase();
            return db.KeyExists(key);
        }
        #endregion

        #region Redis Manager

        private static readonly object Locker = new object();
        private static ConnectionMultiplexer _redis;

        private static ConnectionMultiplexer Manager
        {
            get
            {
                if (_redis == null)
                {
                    lock (Locker)
                    {
                        if (_redis != null) return _redis;
                        _redis = GetManager();
                        return _redis;
                    }
                }
                return _redis;
            }
        }

        private static ConnectionMultiplexer GetManager(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = System.Configuration.ConfigurationManager.AppSettings["RedisConnectionString"];
            }
            return ConnectionMultiplexer.Connect(connectionString);
        }

        #endregion
    }
}