using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppCommodityOrderItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCommodityOrderItemQueryModel : AopObject
    {
        /// <summary>
        /// 商户订单ID号
        /// </summary>
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 从第几页开始查询
        /// </summary>
        [XmlElement("start_page")]
        public string StartPage { get; set; }
    }
}
