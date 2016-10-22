using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitInfoDetail : AopObject
    {
        /// <summary>
        /// 面额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 权益类型  PRE_FUND（卡面额）  DISCOUNT：折扣  COUPON：券
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 个数
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
