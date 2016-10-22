using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignWhitelistUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignWhitelistUpdateModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 白名单。逗号分隔开
        /// </summary>
        [XmlElement("user_white_list")]
        public string UserWhiteList { get; set; }
    }
}
