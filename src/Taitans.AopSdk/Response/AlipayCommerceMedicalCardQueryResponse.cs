using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家支付宝账号，将用＊号屏蔽部分内容
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  卡颁发机构名称
        /// </summary>
        [XmlElement("card_org_name")]
        public string CardOrgName { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  卡颁发机构编号
        /// </summary>
        [XmlElement("card_org_no")]
        public string CardOrgNo { get; set; }

        /// <summary>
        /// 城市编码(格式为：行政区域代码)
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// Json格式的业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  签约成功时间。 格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 000102020011
        /// </summary>
        [XmlElement("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 签约状态为成功绑定为不可空  医保卡号
        /// </summary>
        [XmlElement("medical_card_no")]
        public string MedicalCardNo { get; set; }

        /// <summary>
        /// 市级医保卡：CITYINSURANE  省级医保卡:PROVINCEINSURANE
        /// </summary>
        [XmlElement("medical_card_type")]
        public string MedicalCardType { get; set; }

        /// <summary>
        /// 签约结果
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
