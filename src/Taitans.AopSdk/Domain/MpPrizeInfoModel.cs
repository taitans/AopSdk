using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpPrizeInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class MpPrizeInfoModel : AopObject
    {
        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certlot_number")]
        public string CertlotNumber { get; set; }

        /// <summary>
        /// 奖品频率对应的次数，数值，最大999999
        /// </summary>
        [XmlElement("frequency_count")]
        public string FrequencyCount { get; set; }

        /// <summary>
        /// 奖品中奖频率类型: D，每自然日；W，每自然周（从周一至周日）；M，每自然月
        /// </summary>
        [XmlElement("frequency_type")]
        public string FrequencyType { get; set; }

        /// <summary>
        /// 奖品结束时间，yyyy-mm-dd 00:00:00格式，大于起始时间
        /// </summary>
        [XmlElement("prize_end_time")]
        public string PrizeEndTime { get; set; }

        /// <summary>
        /// 1. 创建时不用填； 2. 查询时会返回； 3. 修改活动时，如果不填prize_id,则会新增一个奖品，并且以覆盖的形式执行，如果填原有的prize_id则修改奖品信息。
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品中奖次数，数值，最大999999，该属性不支持修改，修改时透传处理
        /// </summary>
        [XmlElement("prize_max_award_limit")]
        public string PrizeMaxAwardLimit { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品开始时间，yyyy-mm-dd 00:00:00格式
        /// </summary>
        [XmlElement("prize_start_time")]
        public string PrizeStartTime { get; set; }

        /// <summary>
        /// 奖品数量，数值，最大999999
        /// </summary>
        [XmlElement("prize_total")]
        public string PrizeTotal { get; set; }

        /// <summary>
        /// 奖品类型，CAMP_COUPON_PRIZE，定额红包奖品；CAMP_DYNAMIC_COUPON_PRIZE，不定额红包奖品；CAMP_POINT_PRIZE，定额积分奖品；CAMP_SECRET_CARD_PRIZE，卡密奖品；CAMP_DYNAMIC_POINT_PRIZE，不定额积分奖品；CAMP_DYNAMIC_CASH_PRIZE，不定额现金奖品；CAMP_DYNAMIC_POINT_PRIZE，不定额支付宝积分奖品；CAMP_GROWTH_POINT_PRIZE，成长点奖品；CAMP_ENTITY_PRIZE，实物奖品；CAMP_COMPOSE_PRIZE，组合奖品；CAMP_PREPAYCARD_PRIZE，预付卡奖品；CAMP_DYNAMIC_PREPAYCARD_PRIZE，不定额预付卡奖品；CAMP_UNIFIED_PRIZE，自定义奖品；CAMP_CERT_PRIZE，凭证奖品；CAMP_SOLITAIRE_SEED_PRIZE，接龙种子奖品，目前支持凭证奖品
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
