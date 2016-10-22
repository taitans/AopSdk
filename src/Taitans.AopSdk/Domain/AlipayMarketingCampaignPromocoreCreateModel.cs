using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromocoreCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPromocoreCreateModel : AopObject
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
        /// 活动中奖次数，最大999999
        /// </summary>
        [XmlElement("award_count")]
        public string AwardCount { get; set; }

        /// <summary>
        /// 活动奖品总中奖几率，99对应99%
        /// </summary>
        [XmlElement("award_rate")]
        public string AwardRate { get; set; }

        /// <summary>
        /// 活动唯一标示,创建时外围必传，幂等性id，活动别名，创建后不能修改。系统会加上前缀，查询返回时会大于32位。
        /// </summary>
        [XmlElement("camp_code")]
        public string CampCode { get; set; }

        /// <summary>
        /// 活动开始时间，yyyy-MM-dd HH:00:00格式(到日)，需要大于活动起始时间
        /// </summary>
        [XmlElement("camp_end_time")]
        public string CampEndTime { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("camp_name")]
        public string CampName { get; set; }

        /// <summary>
        /// 活动开始时间，yyyy-MM-dd HH:00:00格式（到日）
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
        /// 奖品模型，至少需要配置一个奖品
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
        /// 活动触发类型，目前支持CAMP_USER_TRIGGER，用户触发；CAMP_SYS_TRIGGER，系统触发。
        /// </summary>
        [XmlElement("trigger_type")]
        public string TriggerType { get; set; }

        /// <summary>
        /// 实时人群验证规则id
        /// </summary>
        [XmlElement("trigger_user_rule_id")]
        public string TriggerUserRuleId { get; set; }

        /// <summary>
        /// 人群验证规则ID
        /// </summary>
        [XmlElement("user_rule_id")]
        public string UserRuleId { get; set; }
    }
}
