using System.Net.Mime;

namespace mvcProject.Core
{
    public class MvcMessage
    {
        public bool Result { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public static MvcMessage Success(string content = "", string title = "")
        {
            return new MvcMessage
            {
                Result = true,
                Content = content,
                Title = title
            };
        }

        public static MvcMessage Error(string content = "", string title = "")
        {
            return new MvcMessage
            {
                Result = false,
                Content = content,
                Title = title
            };
        }

        public static MvcMessage<T> DataSuccess<T>(T data, string content, string title)
        {
            return MvcMessage<T>.Success(data, content, title);
        }

        public static MvcMessage<T> DataError<T>(string content, string title)
        {
            return MvcMessage<T>.Error(content, title);
        }
    }

    public class MvcMessage<T> : MvcMessage
    {
        public T Data { get; set; }

        public static MvcMessage<T> Success(T data = default(T), string content = "", string title = "")
        {
            return new MvcMessage<T>
            {
                Data = data,
                Result = true,
                Content = content,
                Title = title
            };
        }

        public new static MvcMessage<T> Error(string content = "", string title = "")
        {
            return new MvcMessage<T>
            {
                Data = default(T),
                Result = false,
                Content = content,
                Title = title
            };
        }
    }
}