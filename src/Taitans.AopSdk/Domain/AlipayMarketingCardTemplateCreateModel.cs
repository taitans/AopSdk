using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 业务卡号前缀
        /// </summary>
        [XmlElement("biz_no_prefix")]
        public string BizNoPrefix { get; set; }

        /// <summary>
        /// 业务卡号后缀长度
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
        /// 字段规则列表
        /// </summary>
        [XmlArray("field_rule_list")]
        [XmlArrayItem("template_field_rule_d_t_o")]
        public List<TemplateFieldRuleDTO> FieldRuleList { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务Code
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
        /// 模板样式信息
        /// </summary>
        [XmlElement("template_style_info")]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }

        /// <summary>
        /// qrcode: 二维码  dqrcode: 动态二维码  barcode: 条码  dbarcode: 动态条码  text: 文本  url: 连接
        /// </summary>
        [XmlElement("write_off_type")]
        public string WriteOffType { get; set; }
    }
}
