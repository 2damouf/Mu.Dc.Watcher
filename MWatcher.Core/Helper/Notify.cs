using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MWatcher.Core
{
    public class Notify
    {
        public static void Alarm()
        {
            SoundPlayer player = new SoundPlayer(@"C:\alarm.wav");
            player.Play();
        }
        public static void SendWpNotify(string msgBody)
        {
            const string AccountSid = "";
            const string AuthToken = "";
            try
            {
                TwilioClient.Init(AccountSid, AuthToken);
                MessageResource.Create(from: new Twilio.Types.PhoneNumber(""), body: msgBody, to: new Twilio.Types.PhoneNumber(""));
            }
            catch
            {
            }
        }
        public static void SendNotify(string str, string title)
        {
            #region Zort Notif

            WebRequest istekYolla = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            istekYolla.Method = "post";
            istekYolla.Headers.Add("");
            istekYolla.Headers.Add("");
            istekYolla.ContentType = "application/json";
            var payload = new
            {
                to = "/topics/Mu",
                priority = "high",
                content_available = true,
                notification = new
                {
                    body = str,
                    title = title,
                    badge = 1
                },
                data = new
                {
                    key1 = "value1",
                    key2 = "value2"
                }

            };

            string postbody = JsonConvert.SerializeObject(payload).ToString();
            Byte[] byteArray = Encoding.UTF8.GetBytes(postbody);
            istekYolla.ContentLength = byteArray.Length;
            using (Stream dataStream = istekYolla.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                using (WebResponse tResponse = istekYolla.GetResponse())
                {
                    using (Stream dataStreamResponse = tResponse.GetResponseStream())
                    {
                        if (dataStreamResponse != null) using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                //result.Response = sResponseFromServer;
                            }
                    }
                }
            }
            #endregion
        }
    }
}

