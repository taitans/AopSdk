using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LabelFilter Data Structure.
    /// </summary>
    [Serializable]
    public class LabelFilter : AopObject
    {
        /// <summary>
        /// 标签组名，商户自定义的标签固定为label_id_list，支付宝开放的标签详见<a href="https://i.alipayobjects.com/i/ecmng/zip/201501/FirstPartOfTagsFromAlipay.zip?spm=a219a.7629140.0.0.FHtmkZ&file=FirstPartOfTagsFromAlipay.zip">支付宝开放标签</a>
        /// </summary>
        [XmlElement("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 操作符，支持=、!=、in三个操作符；其中in表示是某几个标签中的一个
        /// </summary>
        [XmlElement("op")]
        public string Op { get; set; }

        /// <summary>
        /// 标签数组，用于组装最后的表达式
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("string")]
        public List<string> Values { get; set; }
    }
}
