using Newtonsoft.Json;
using System;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// 统一收单线下交易查询
    /// </summary>
    [Serializable]
    public class AlipayTradeQueryModel : AopObject
    {
        /// <summary>
        /// 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。  trade_no,out_trade_no如果同时存在优先取trade_no
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
