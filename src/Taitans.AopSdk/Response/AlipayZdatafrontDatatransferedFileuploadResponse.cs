using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayZdatafrontDatatransferedFileuploadResponse.
    /// </summary>
    public class AlipayZdatafrontDatatransferedFileuploadResponse : AopResponse
    {
        /// <summary>
        /// 数据上传结果，true/false
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
