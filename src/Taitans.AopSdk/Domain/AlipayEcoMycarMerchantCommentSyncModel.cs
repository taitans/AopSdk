using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarMerchantCommentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMerchantCommentSyncModel : AopObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
