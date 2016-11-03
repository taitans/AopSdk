using System.Collections.Generic;
using Newtonsoft.Json;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// 统一收单交易结算接口
    /// </summary>
    public class AlipayTradeOrderSettleModel : AopObject
    {
        /// <summary>
        /// 操作员id
        /// </summary>
        [JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 结算请求流水号
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细信息
        /// </summary>
        [JsonProperty("open_api_royalty_detail_info_pojo")]
        public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
