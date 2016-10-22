using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoTool Data Structure.
    /// </summary>
    [Serializable]
    public class PromoTool : AopObject
    {
        /// <summary>
        /// 集点卡工具
        /// </summary>
        [XmlElement("point_card")]
        public PointCard PointCard { get; set; }

        /// <summary>
        /// 奖品发放的规则
        /// </summary>
        [XmlElement("send_rule")]
        public SendRule SendRule { get; set; }

        /// <summary>
        /// 券对象
        /// </summary>
        [XmlElement("voucher")]
        public Voucher Voucher { get; set; }

        /// <summary>
        /// 营销工具uid,创建营销活动时无需设置
        /// </summary>
        [XmlElement("voucher_no")]
        public string VoucherNo { get; set; }
    }
}
