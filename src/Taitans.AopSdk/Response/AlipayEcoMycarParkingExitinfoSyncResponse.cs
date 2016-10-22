using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingExitinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingExitinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回状态：1为成功，0为失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
