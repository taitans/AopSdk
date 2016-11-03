using System.Collections.Generic;
using Newtonsoft.Json;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// 统一收单交易创建接口
    /// </summary>
    public class AlipayTradeCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝的店铺编号
        /// </summary>
        [JsonProperty("alipay_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 对交易或商品的描述
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// 买家的支付宝唯一用户号（2088开头的16位纯数字）,和buyer_logon_id不能同时为空
        /// </summary>
        [JsonProperty("buyer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝账号，和buyer_id不能同时为空
        /// </summary>
        [JsonProperty("buyer_logon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 可打折金额.  参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  如果该值未传入，但传入了【订单总金额】，【不可打折金额】则该值默认为【订单总金额】-【不可打折金额】
        /// </summary>
        [JsonProperty("discountable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息.Json格式.  其它说明详见：“商品明细说明”
        /// </summary>
        [JsonProperty("goods_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户操作员编号
        /// </summary>
        [JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 描述分账信息，json格式。
        /// </summary>
        [JsonProperty("royalty_info", NullValueHandling = NullValueHandling.Ignore)]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。  如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        /// <summary>
        /// 二级商户信息,当前只对特殊银行机构特定场景下使用此字段
        /// </summary>
        [JsonProperty("sub_merchant", NullValueHandling = NullValueHandling.Ignore)]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [JsonProperty("terminal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalId { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
        /// </summary>
        [JsonProperty("timeout_express", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  如果同时传入了【打折金额】，【不可打折金额】，【订单总金额】三者，则必须满足如下条件：【订单总金额】=【打折金额】+【不可打折金额】
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额.  不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]  如果该值未传入，但传入了【订单总金额】,【打折金额】，则该值默认为【订单总金额】-【打折金额】
        /// </summary>
        [JsonProperty("undiscountable_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string UndiscountableAmount { get; set; }
    }
}
