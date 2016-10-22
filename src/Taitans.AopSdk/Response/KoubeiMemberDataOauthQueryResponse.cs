using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMemberDataOauthQueryResponse.
    /// </summary>
    public class KoubeiMemberDataOauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 代运营的商户id
        /// </summary>
        [XmlElement("operator_partner_id")]
        public string OperatorPartnerId { get; set; }

        /// <summary>
        /// 操作人身份
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }
    }
}
