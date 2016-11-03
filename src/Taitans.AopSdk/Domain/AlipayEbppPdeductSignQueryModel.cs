using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppPdeductSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppPdeductSignQueryModel : AopObject
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
