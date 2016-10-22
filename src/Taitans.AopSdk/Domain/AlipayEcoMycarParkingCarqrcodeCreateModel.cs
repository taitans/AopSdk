using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingCarqrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingCarqrcodeCreateModel : AopObject
    {
        /// <summary>
        /// 停车场编号
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
