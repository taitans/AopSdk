using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardQueryModel : AopObject
    {
        /// <summary>
        /// 用户信息  和卡号不能同时为空，且如果提供userID且卡号不填时，查询该用户在商户下的所有卡信息
        /// </summary>
        [XmlElement("card_user_info")]
        public CardUserInfo CardUserInfo { get; set; }

        /// <summary>
        /// 扩展信息，暂时没有
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作卡号。  target_card_no和card_user_info不能同时为空。
        /// </summary>
        [XmlElement("target_card_no")]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型（会员卡查询，只能提供支付宝端的卡号）  BIZ_CARD：支付宝卡号  EXTERNAL_CARD：商户卡号  如果卡号不空，则类型不能为空
        /// </summary>
        [XmlElement("target_card_no_type")]
        public string TargetCardNoType { get; set; }
    }
}
