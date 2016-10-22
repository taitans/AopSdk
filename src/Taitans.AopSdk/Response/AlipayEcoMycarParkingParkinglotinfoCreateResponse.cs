using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoCreateResponse.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝返回停车场id。成功传，失败不传
        /// </summary>
        [XmlElement("alipay_parking_id")]
        public string AlipayParkingId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("stauts")]
        public string Stauts { get; set; }
    }
}
