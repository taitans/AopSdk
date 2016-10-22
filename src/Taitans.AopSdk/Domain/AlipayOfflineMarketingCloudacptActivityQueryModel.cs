using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingCloudacptActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingCloudacptActivityQueryModel : AopObject
    {
        /// <summary>
        /// partener id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
