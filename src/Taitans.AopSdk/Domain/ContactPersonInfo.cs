using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContactPersonInfo : AopObject
    {
        /// <summary>
        /// 联系人邮箱地址，入驻申请审核结果会发送至该邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号，入驻申请结果会通过短信的形式发送至该手机号码
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 企业联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }
    }
}
