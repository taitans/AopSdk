using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateFieldRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateFieldRuleDTO : AopObject
    {
        /// <summary>
        /// 字段名称，现在支持  Balance：金额  Point：整数  Level：任意字符串  LevelShowName：任意字符串（卡包展现）  OpenDate：开卡日期  ValidDate：过期日期
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 规则名  ASSIGN_FROM_REQUEST:  从请求中指定(请求中的rule_name)  DATE_IN_FUTURE: 生成一个未来的日期（格式YYYY-MM-DD)  CONST: 常量
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 根据rule_name，采取相应取值策略  CONST：直接设置目标值  DATE_IN_FUTURE：10m或10d 分别表示10个月或10天  ASSIGN_FROM_REQUEST：在Reuqest请求中的key名称，以大写开头（Balance、Point、Level）
        /// </summary>
        [XmlElement("rule_value")]
        public string RuleValue { get; set; }
    }
}
