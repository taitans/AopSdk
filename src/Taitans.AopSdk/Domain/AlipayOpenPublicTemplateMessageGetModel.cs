using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicTemplateMessageGetModel : AopObject
    {
        /// <summary>
        /// 消息母板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
