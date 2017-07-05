using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace ElecSales.Services
{
    //TODO SendCloud邮件
    public class SendCloundManager
    {
        //TODO 以下敏感字符不应该存在这里,通过WebConfig-appSettings配置,然后调用
        private static string ApiUser => "";

        private static string ApiKey => "";

        private static string Url => "http://api.sendcloud.net/apiv2/mail/send";

        private static string TempUrl => "http://sendcloud.sohu.com/webapi/mail.send_template.json";

        public delegate List<KeyValuePair<string, string>> ParamListInit(List<KeyValuePair<string, string>> model);

        //TODO 详细文档请参考SendCloundManagerApi: http://sohu.sendcloud.net/doc/email/send_email/
        //TODO Refer to the SendCloundManagerAPI(http://sohu.sendcloud.net/doc/email/send_email/) for detailed documentation
        private static void SendClound(ParamListInit fac)
        {
            string url;
            var client = new HttpClient();
            var paramList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("apiUser", ApiUser),
                new KeyValuePair<string, string>("apiKey", ApiKey),
                new KeyValuePair<string, string>("from", "569760357@qq.com"),
                new KeyValuePair<string, string>("fromname", "mvcProject")
            };
            if (fac == null)
            {
                //TODO 这里作为工单提示,有疑问请mailto:lichen@fissoft.com 
                //TODO Here is a reminder for the repair order, if you have any questions, please mailto: lichen @fissoft.com
                paramList.AddRange(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("template_invoke_name", "DHQ_Test"),
                    new KeyValuePair<string, string>("substitution_vars", "{\"to\":[\"lichen@fissoft.com\"]}")
                });
                url = TempUrl;
            }
            else
            {
                paramList = fac.Invoke(paramList);
                url = Url;
            }
            var httpResult = client.PostAsync(new Uri(url), new FormUrlEncodedContent(paramList)).Result;
            var result = httpResult.Content.ReadAsStringAsync().Result;
            var resultModel = JsonConvert.DeserializeObject<SendCloudResultViewModel>(result);
            Console.WriteLine(resultModel);
        }

        public static void Send(string receives, string title, string htmlContent)
        {
            SendClound((model) =>
            {
                var resultMdoel = model;
                resultMdoel.AddRange(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("subject", title),
                    new KeyValuePair<string, string>("html", htmlContent),
                    new KeyValuePair<string, string>("to", receives)
                });
                return resultMdoel;
            });
        }

        public static void TempSend(string receives)
        {
            SendClound(null);
        }
    }
}