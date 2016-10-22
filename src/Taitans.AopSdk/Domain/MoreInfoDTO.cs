using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MoreInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MoreInfoDTO : AopObject
    {
        /// <summary>
        /// opennative时填写
        /// </summary>
        [XmlArray("descs")]
        [XmlArrayItem("string")]
        public List<string> Descs { get; set; }

        /// <summary>
        /// 扩展参数，需要URL地址回带的值，JSON格式(openweb时填)
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 二级页面标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 超链接(openweb时填)
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
