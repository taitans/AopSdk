using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromocoreUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPromocoreUpdateModel : AopObject
    {
        /// <summary>
        /// 账户参与次数，数值
        /// </summary>
        [XmlElement("account_count")]
        public string AccountCount { get; set; }

        /// <summary>
        /// 设备appid参与次数，数值
        /// </summary>
        [XmlElement("appid_count")]
        public string AppidCount { get; set; }

        /// <summary>
        /// 活动奖品总中奖几率，99对应99%
        /// </summary>
        [XmlElement("award_rate")]
        public string AwardRate { get; set; }

        /// <summary>
        /// 活动结束时间，yyyy-mm-dd 00:00:00格式，大于起始时间
        /// </summary>
        [XmlElement("camp_end_time")]
        public string CampEndTime { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("camp_name")]
        public string CampName { get; set; }

        /// <summary>
        /// 活动开始时间，yyyy-mm-dd 00:00:00格式
        /// </summary>
        [XmlElement("camp_start_time")]
        public string CampStartTime { get; set; }

        /// <summary>
        /// 凭证验证规则id
        /// </summary>
        [XmlElement("cert_rule_id")]
        public string CertRuleId { get; set; }

        /// <summary>
        /// 账户证件号参与次数，数值
        /// </summary>
        [XmlElement("certification_count")]
        public string CertificationCount { get; set; }

        /// <summary>
        /// 手机号参与次数，数值
        /// </summary>
        [XmlElement("mobile_count")]
        public string MobileCount { get; set; }

        /// <summary>
        /// 奖品模型，至少有一个奖品模型
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("mp_prize_info_model")]
        public List<MpPrizeInfoModel> PrizeList { get; set; }

        /// <summary>
        /// 营销验证规则id
        /// </summary>
        [XmlElement("promo_rule_id")]
        public string PromoRuleId { get; set; }

        /// <summary>
        /// 人群验证规则
        /// </summary>
        [XmlElement("user_rule_id")]
        public string UserRuleId { get; set; }
    }
}
