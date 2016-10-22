using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelAddModel : AopObject
    {
        /// <summary>
        /// 标签名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
