using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LineBot.Controllers
{
    public class LineWebHookController : isRock.LineBot.LineWebHookControllerBase
    {

        
        [Route("api/LineBotWebHook")]
        [HttpPost]
        public IHttpActionResult POST()
        {
            var AdminUserId = "Uf9791941d77428c8d482d024f8f3522c";

            try
            {
                //設定ChannelAccessToken
                this.ChannelAccessToken = "RT7uz9W2KCSIctlQ95b2PsqBPSJn2wCJ52Q0cYRycVUW5R1AqOtGDFvgBBKUiEZty7Q3mGIvh5Ei1hipXF+tGtm5fvMNjJ77YHd4UoQvokRJcqgvLf9aPnZqv+2Oivnt0VCueMaZPLF4JLFLW7deWAdB04t89/1O/w1cDnyilFU=";
                //取得Line Event
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                var responseMsg = "";
                //準備回覆訊息
                if (LineEvent.type.ToLower() == "message" && LineEvent.message.type == "text")
                {
                    var ret = Translator(LineEvent.message.text);
                    //set up console encoding

                    foreach (var item in ret[0].translations)
                    {
                        responseMsg = $"翻譯結果{item.to} : {item.text}";
                    }

                }
                else if (LineEvent.type.ToLower() == "message")
                    responseMsg = $"收到 event : {LineEvent.type} type: {LineEvent.message.type} ";
                else
                    responseMsg = $"收到 event : {LineEvent.type} ";
                //回覆訊息
                this.ReplyMessage(LineEvent.replyToken, responseMsg);
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //回覆訊息
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
        public dynamic Translator(string str)
        {
            var client = new HttpClient();
            string endpoint = "https://api.cognitive.microsofttranslator.com/translate?api-version=3.0&to=en";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "1a03f218fd66492dafda07e002db6c1c");
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Region", "eastasia");


            var JSON = "[{\"Text\":\"{" + str + "}\"}]";
            var content = new StringContent(JSON, System.Text.Encoding.UTF8, "application/json");

            var response = client.PostAsync(endpoint, content).Result;
            var ResultJSON = response.Content.ReadAsStringAsync().Result;
            var Obj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(ResultJSON);

            return Obj;

        }
    }
}

