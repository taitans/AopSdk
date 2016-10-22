using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppAlipayEbppPdeductQuerySignInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppAlipayEbppPdeductQuerySignInfoModel : AopObject
    {
        /// <summary>
        /// 支付宝代扣协议Id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
