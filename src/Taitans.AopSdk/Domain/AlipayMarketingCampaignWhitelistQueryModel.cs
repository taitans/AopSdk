using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignWhitelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignWhitelistQueryModel : AopObject
    {
        /// <summary>
        /// 活动od
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
