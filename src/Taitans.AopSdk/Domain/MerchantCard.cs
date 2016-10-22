using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCard Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCard : AopObject
    {
        /// <summary>
        /// 资金卡余额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 支付宝业务卡号  (alipay.marketing.card.open接口不需要提供该字段)
        /// </summary>
        [XmlElement("biz_card_no")]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 商户卡ID（外部会员卡必须提供）
        /// </summary>
        [XmlElement("external_card_no")]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 会员卡等级，由商户自定义。
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 会员卡积分。
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
