using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoUpdateResponse : AopResponse
    {
        /// <summary>
        /// 返回状态：1为成功，0为失败
        /// </summary>
        [XmlElement("stauts")]
        public string Stauts { get; set; }
    }
}
