using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampUpdateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampUpdateResponse : AopResponse
    {
        /// <summary>
        /// 操作结果状态
        /// </summary>
        [XmlElement("camp_result")]
        public bool CampResult { get; set; }
    }
}
