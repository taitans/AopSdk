using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingEnterinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回状态：1为成功，0为失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
