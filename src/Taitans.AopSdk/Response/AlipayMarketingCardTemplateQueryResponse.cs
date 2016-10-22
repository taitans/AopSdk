using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateQueryResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 前缀
        /// </summary>
        [XmlElement("biz_no_prefix")]
        public string BizNoPrefix { get; set; }

        /// <summary>
        /// 卡号长度
        /// </summary>
        [XmlElement("biz_no_suffix_len")]
        public string BizNoSuffixLen { get; set; }

        /// <summary>
        /// OUT_MEMBER_CARD：外部权益卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 栏位信息
        /// </summary>
        [XmlArray("column_info_list")]
        [XmlArrayItem("template_column_info_d_t_o")]
        public List<TemplateColumnInfoDTO> ColumnInfoList { get; set; }

        /// <summary>
        /// 卡字段规则
        /// </summary>
        [XmlArray("field_rule_list")]
        [XmlArrayItem("template_field_rule_d_t_o")]
        public List<TemplateFieldRuleDTO> FieldRuleList { get; set; }

        /// <summary>
        /// 服务标签列表
        /// </summary>
        [XmlArray("service_label_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceLabelList { get; set; }

        /// <summary>
        /// 权益信息
        /// </summary>
        [XmlArray("template_benefit_info")]
        [XmlArrayItem("template_benefit_info_d_t_o")]
        public List<TemplateBenefitInfoDTO> TemplateBenefitInfo { get; set; }

        /// <summary>
        /// 样式信息
        /// </summary>
        [XmlElement("template_style_info")]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }
    }
}
