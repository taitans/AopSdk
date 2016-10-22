using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMemberDataCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 父品类编码. (查询顶级类目时值传0)
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
