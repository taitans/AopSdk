using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FilterTag Data Structure.
    /// </summary>
    [Serializable]
    public class FilterTag : AopObject
    {
        /// <summary>
        /// 过滤条件的标签code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 分组过滤条件
        /// </summary>
        [XmlElement("filter_items")]
        public string FilterItems { get; set; }
    }
}
