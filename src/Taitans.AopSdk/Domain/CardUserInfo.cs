using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardUserInfo : AopObject
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("user_uni_id")]
        public string UserUniId { get; set; }

        /// <summary>
        /// ID类型  LOGON_ID：用户登录ID，邮箱或者手机号格式；  UID：用户支付宝用户号，以2088开头的16位纯数字组成；  BINDING_MOBILE：用户支付宝账号绑定的手机号。
        /// </summary>
        [XmlElement("user_uni_id_type")]
        public string UserUniIdType { get; set; }
    }
}
