using Newtonsoft.Json;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// 统一收单交易撤销接口
    /// </summary>
    public class AlipayTradeCancelModel : AopObject
    {
        /// <summary>
        /// 原支付请求的商户订单号,和支付宝交易号不能同时为空
        /// </summary>
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
