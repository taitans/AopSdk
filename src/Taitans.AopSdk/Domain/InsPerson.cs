using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPerson Data Structure.
    /// </summary>
    [Serializable]
    public class InsPerson : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝资金账户;投保人用于支付保费,被保人用作理赔金收入账户
        /// </summary>
        [XmlElement("alipay_account_no")]
        public string AlipayAccountNo { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 投保参数;标准json格式
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 渠道账号对应的uid;如果证件类型字段没填则必填
        /// </summary>
        [XmlElement("channel_account_id")]
        public string ChannelAccountId { get; set; }

        /// <summary>
        /// 渠道账号类型;1:支付宝账号 2:淘宝账号;如果证件类型字段没填则必填
        /// </summary>
        [XmlElement("channel_account_type")]
        public string ChannelAccountType { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 性别;M:男 F:女
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 证件上名称;如果渠道账号字段没填则必填
        /// </summary>
        [XmlElement("id_card_name")]
        public string IdCardName { get; set; }

        /// <summary>
        /// 证件号码;如果渠道账号字段没填则必填
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 证件类型;如果渠道账号字段没填则必填   100:居民身份证;102:护照;103:军官证;104:士兵证;105:港澳居民往来内地通行证;106:台湾同胞往来大陆通行证;109:警官证
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
