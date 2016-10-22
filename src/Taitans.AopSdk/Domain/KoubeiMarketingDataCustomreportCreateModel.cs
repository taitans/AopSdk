using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportCreateModel : AopObject
    {
        /// <summary>
        /// 自定义报表规则条件信息
        /// </summary>
        [XmlElement("report_condition_info")]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}
