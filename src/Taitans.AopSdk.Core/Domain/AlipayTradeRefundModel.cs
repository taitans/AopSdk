using Newtonsoft.Json;
using System;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// 统一收单交易退款接口
    /// </summary>
    [Serializable]
    public class AlipayTradeRefundModel : AopObject
    {
        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        [JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传。
        /// </summary>
        [JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号,不能和 trade_no同时为空。
        /// </summary>
        [JsonProperty("out_trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款的原因说明
        /// </summary>
        [JsonProperty("refund_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundReason { get; set; }

        /// <summary>
        /// 商户的门店编号
        /// </summary>
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        [JsonProperty("terminal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalId { get; set; }

        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        [JsonProperty("trade_no", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeNo { get; set; }
    }
}
