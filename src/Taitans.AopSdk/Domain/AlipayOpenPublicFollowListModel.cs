using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicFollowListModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicFollowListModel : AopObject
    {
        /// <summary>
        /// 当关注者数量超过10000时使用，本次拉取数据中第一个用户的userId，从上次接口调用返回值中获取。第一次调用置空
        /// </summary>
        [XmlElement("next_user_id")]
        public string NextUserId { get; set; }
    }
}
