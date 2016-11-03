using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using System.IO;
using Newtonsoft.Json;
using Aop.Api.Util;

namespace Titans.AopSdk.Tests
{
    [TestClass]
    public class Trade
    {

        //支付宝网关地址
        // -----开发环境地址-----
        //private string serverUrl = "https://openfile.alipay.com/chat/multimedia.do";

        // -----沙箱地址-----
        //private string serverUrl = "http://openapi.alipaydev.com/gateway.do";

        // -----线上地址-----
        private string serverUrl = "https://openapi.alipaydev.com/gateway.do";

        //应用ID
        string appId = "2016082000297526";

        //商户私钥
        string private_key = @"MIICXAIBAAKBgQDX/i/wBNoer/YyoBYoqTXIXIO31/FR+K7gTDrM4vCif2u69dzR
nYfx32N2JShS/4zfArtUINh7zPK9fX7sgyWjP19P3G1Fl0sj+3zT7BTYDZYXb4/4
irFK18rbG+McMnjS3p6bZdWBB1PH8H6CqLMVN6eab9yB/p8lP2dmilQErwIDAQAB
AoGAMTmlAzaX31aK7Y6+fhXSRA+RlVyJivz6HfRBkmBGJ0KS8tEFumAEk4Mtz8c4
IXJMUKb2un2h2NUknTr0qkJZWSfRojVxsc9yzV284ihw2LyIqzE4KwGjw720/vus
rhwDdSeQMJ23lu/1dWYUkH++kuxeJOfUDMw6YCdItUY2a8ECQQD2wRXHF4MsRJj5
hJWf9zfB1lBOG8dSXXBGJ3wErMjuZF1JfJZ6g3o9Tcmr1JAP0mye6iIn3WaZaniH
QcZfqGFVAkEA4BYImXNArztARNhL6vwDEOa5YvBZXV7ePvFy0wBoO7BXxq2aRul2
aUeUw3b2xiR8h/5OFWIqD+6rUdeG9JUd8wJBALcxDEj91L21w9hjLW5QbI203XPP
vcARbLw4riMOYDJUQsm+/DzChasjqBiwu69zan7kli0Aex5k5EyOcYctC+0CQBMC
y4f5NyumozU0BHzTFI+Cg4fZTDuXqNM+OLed+TnXJBs+7y/E7r7Py9cpaJY20jnX
YVh/E4J2hSJUXqaxX/ECQDk7UXLc/lwP9AKcnhTYhLo8MCH8Ifz21CgR7tDmk5mD
2k/JaMERl+jbgKeG94Ngkr7C4myCsjs3o+8K4S2cHJg=";

        string public_key = @"MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDX/i/wBNoer/YyoBYoqTXIXIO31/FR+K7gTDrM4vCif2u69dzRnYfx32N2JShS/4zfArtUINh7zPK9fX7sgyWjP19P3G1Fl0sj+3zT7BTYDZYXb4/4irFK18rbG+McMnjS3p6bZdWBB1PH8H6CqLMVN6eab9yB/p8lP2dmilQErwIDAQAB";

        private IAopClient GetClient()
        {
            IAopClient client = new DefaultAopClient(serverUrl, appId, private_key, "json", "utf-8", "RSA", public_key);

            client = new DefaultAopClient(serverUrl, appId, private_key, "json", "utf-8");
            return client;
        }

        /// <summary>
        /// 统一收单线下交易查询
        /// </summary>
        [TestMethod]
        public void Query()
        {
            IAopClient client = GetClient();
            AlipayTradeQueryRequest request = new AlipayTradeQueryRequest();
            request.BizContent = "{" +
            "    \"out_trade_no\":\"20150320010101001\"," +
            "    \"trade_no\":\"2014112611001073956707\"" +
            "  }";

            AlipayTradeQueryResponse response = client.Execute(request);
        }

        /// <summary>
        /// 统一收单线下交易预创建
        /// </summary>
        [TestMethod]
        public void Precreate()
        {
            IAopClient client = GetClient();
            AlipayTradePrecreateRequest request = new AlipayTradePrecreateRequest();

            //TODO：此处替换官方文档
            request.BizContent = "{" +
"    \"out_trade_no\":\"20160320010101001\"," +
"    \"total_amount\":88.88," +
"    \"discountable_amount\":8.88," +
"    \"undiscountable_amount\":80," +
"    \"buyer_logon_id\":\"15901825620\"," +
"    \"subject\":\"Iphone6 16G\"," +
"    \"body\":\"Iphone6 16G\"," +
"    \"timeout_express\":\"90m\"," +
"    \"sub_merchant\":{" +
"      \"merchant_id\":\"19023454\"" +
"    }" +
"  }";

            request.BizContent = JsonConvert.SerializeObject(new Entities.Precreate()
            {
                out_trade_no = "20160320010101001",
                subject = "Iphone6 16G",
                total_amount = 88.88
            });


            AlipayTradePrecreateResponse response = client.Execute(request);

            if (!response.IsError)
            {
                Console.WriteLine("调用成功");
            }
            else
            {
                Console.WriteLine("调用失败");
            }

            Assert.IsFalse(response.IsError);
        }


        /// <summary>
        /// 统一收单交易创建接口
        /// </summary>
        [TestMethod]
        public void Create()
        {
            IAopClient client = GetClient();
            AlipayTradeCreateRequest request = new AlipayTradeCreateRequest();
            request.BizContent = "{" +
"    \"out_trade_no\":\"20150320010101001\"," +
"    \"seller_id\":\"2088102172273210\"," +
"    \"total_amount\":88.88," +
"    \"discountable_amount\":8.88," +
"    \"undiscountable_amount\":80.00," +
"    \"buyer_logon_id\":\"15901825620\"," +
"    \"subject\":\"Iphone6 16G\"," +
"    \"body\":\"Iphone6 16G\"," +
"    \"buyer_id\":\"2088102146225135\"," +
"      \"goods_detail\":[{" +
"                \"goods_id\":\"apple-01\"," +
"        \"alipay_goods_id\":\"20010001\"," +
"        \"goods_name\":\"ipad\"," +
"        \"quantity\":1," +
"        \"price\":2000," +
"        \"goods_category\":\"34543238\"," +
"        \"body\":\"特价手机\"," +
"        \"show_url\":\"http://www.alipay.com/xxx.jpg\"" +
"        }]," +
"    \"operator_id\":\"Yx_001\"," +
"    \"store_id\":\"NJ_001\"," +
"    \"terminal_id\":\"NJ_T_001\"," +
"    \"extend_params\":{" +
"      \"sys_service_provider_id\":\"2088511833207846\"," +
"      \"hb_fq_num\":\"3\"," +
"      \"hb_fq_seller_percent\":\"100\"" +
"    }," +
"    \"timeout_express\":\"90m\"," +
"    \"royalty_info\":{" +
"      \"royalty_type\":\"ROYALTY\"," +
"        \"royalty_detail_infos\":[{" +
"                    \"serial_no\":1," +
"          \"trans_in_type\":\"userId\"," +
"          \"batch_no\":\"123\"," +
"          \"out_relation_id\":\"20131124001\"," +
"          \"trans_out_type\":\"userId\"," +
"          \"trans_out\":\"2088101126765726\"," +
"          \"trans_in\":\"2088101126708402\"," +
"          \"amount\":0.1," +
"          \"desc\":\"分账测试1\"," +
"          \"amount_percentage\":\"100\"" +
"          }]" +
"    }," +
"    \"alipay_store_id\":\"2016041400077000000003314986\"," +
"    \"sub_merchant\":{" +
"      \"merchant_id\":\"19023454\"" +
"    }" +
"  }";

            request.BizContent = JsonConvert.SerializeObject(new Entities.Create()
            {
                out_trade_no = "20120320010101001",
                subject = "Iphone 100",
                total_amount = 8888.88,
                buyer_logon_id = "rtatxe0222@sandbox.com",
            });


            AlipayTradeCreateResponse response = client.Execute(request);
            if (!response.IsError)
            {
                Console.WriteLine("调用成功");
            }
            else
            {
                Console.WriteLine("调用失败");
            }

            Assert.IsFalse(response.IsError);
        }

        [TestMethod]
        public void Check()
        {
            string publickey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDIgHnOn7LLILlKETd6BFRJ0GqgS2Y3mn1wMQmyh9zEyWlz5p1zrahRahbXAfCfSqshSNfqOmAQzSHRVjCqjsAw1jyqrXaPdKBmr90DIpIxmIyKXv4GGAkPyJ/6FTFY99uhpiq0qadD/uSzQsefWo0aTvP/65zi3eof7TcZ32oWpwIDAQAB";

            string sign = "jKRnSXLbf1d+KSv8xIWO3gDRUKcmOemLt0laeIZDelZqETRa/bGlmqFQmt/CF2sRxuXHqZx3Gs5MG+X3dFCUp+ypm5dRlvmKqEi/Pz0XV2/E7eva42gltNx76i2MPA83SlB7zS+N+0ZkARLok4KRofHl72vtGIWCxCZFJhHIlsE=";

            string signcontent = "app_id=2016092600603929&body=phone&buyer_id=2088102169336131&gmt_create=2016-10-30 17:50:12&gmt_payment=2016-10-30 17:50:13&notify_id=f3690a28885f22b325723e5f6bc6df4h06&notify_time=2016-10-30 17:50:13&notify_type=trade_status_sync&out_trade_no=2016102912137&seller_id=2088102177423285&subject=phone8&total_amount=20.21&trade_no=2016103021001004130200039530&trade_status=TRADE_SUCCESS";

            bool istrue = AlipaySignature.RSACheckContent(signcontent, sign, publickey, "utf-8", "RSA", false);

            Assert.IsTrue(istrue);
        }
    }
}
