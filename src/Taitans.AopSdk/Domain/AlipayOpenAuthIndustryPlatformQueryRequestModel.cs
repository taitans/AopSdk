using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthIndustryPlatformQueryRequestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthIndustryPlatformQueryRequestModel : AopObject
    {
        /// <summary>
        /// external_system_name
        /// </summary>
        [XmlElement("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// is_transfer_uid
        /// </summary>
        [XmlElement("is_transfer_uid")]
        public bool IsTransferUid { get; set; }

        /// <summary>
        /// operate_type
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// query_condition
        /// </summary>
        [XmlElement("query_condition")]
        public string QueryCondition { get; set; }
    }
}
