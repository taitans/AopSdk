using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsAddressee Data Structure.
    /// </summary>
    [Serializable]
    public class InsAddressee : AopObject
    {
        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收件人移动电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
