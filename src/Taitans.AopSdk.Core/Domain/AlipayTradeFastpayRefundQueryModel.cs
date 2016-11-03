using Newtonsoft.Json;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// 统一收单交易退款查询
    /// </summary>
    public class AlipayTradeFastpayRefundQueryModel : AopObject
    {
        /// <summary>
        /// 【必须】请求退款接口时，传入的退款请求号，如果在退款请求时未传入，则该值为创建交易时的外部交易号
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 【特殊可选】订单支付时传入的商户订单号,和支付宝交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no
        /// </summary>
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 【特殊可选】支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
