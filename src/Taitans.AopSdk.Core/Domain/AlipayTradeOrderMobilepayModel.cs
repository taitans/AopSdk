using Newtonsoft.Json;
using System;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// 外部商户创建订单并支付
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderMobilepayModel : AopObject
    {
        /// <summary>
        /// 针对用户授权接口，获取用户相关数据时，用于标识用户授权关系
        /// </summary>
        [JsonProperty("auth_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Iphone6 16G
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 收款支付宝用户ID。 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        /// 商品的标题/交易标题/订单标题/订单关键字等。
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
        /// </summary>
        [JsonProperty("timeout_express", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
