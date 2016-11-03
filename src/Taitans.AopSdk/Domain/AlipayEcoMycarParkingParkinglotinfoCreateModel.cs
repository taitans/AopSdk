using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingParkinglotinfoCreateModel : AopObject
    {
        /// <summary>
        /// 城市编号（国家统一标准编码）
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 联系人支付宝账户
        /// </summary>
        [XmlElement("contact_alipay")]
        public string ContactAlipay { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("contact_emali")]
        public string ContactEmali { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人座机
        /// </summary>
        [XmlElement("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 联系人微信
        /// </summary>
        [XmlElement("contact_weixin")]
        public string ContactWeixin { get; set; }

        /// <summary>
        /// 设备商名称
        /// </summary>
        [XmlElement("equipment_name")]
        public string EquipmentName { get; set; }

        /// <summary>
        /// 纬度；最长15位字符（包括小数点）， 注：高德坐标系
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度；最长15位字符（包括小数点）， 注：高德坐标系
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        [XmlElement("parking_address")]
        public string ParkingAddress { get; set; }

        /// <summary>
        /// 停车场结束营业时间，格式"yyyy-MM-ddHH:mm:ss"
        /// </summary>
        [XmlElement("parking_end_time")]
        public string ParkingEndTime { get; set; }

        /// <summary>
        /// 收费说明
        /// </summary>
        [XmlElement("parking_fee_description")]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        /// 停车场编号（由设备商系统）
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场类型，1为小区停车场、2为商圈停车场、3为路面停车场、4为园区停车场、5为写字楼停车场、6为私人停车场
        /// </summary>
        [XmlElement("parking_lot_type")]
        public string ParkingLotType { get; set; }

        /// <summary>
        /// 停车场名称
        /// </summary>
        [XmlElement("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 停车位数目
        /// </summary>
        [XmlElement("parking_number")]
        public string ParkingNumber { get; set; }

        /// <summary>
        /// 停车场类型(1为地面，2为地下，3为路边)（多个类型，中间用,隔开
        /// </summary>
        [XmlElement("parking_type")]
        public string ParkingType { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 缴费模式（1为停车卡缴费，2为物料缴费，3为中央缴费机）
        /// </summary>
        [XmlElement("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("shopingmall_id")]
        public string ShopingmallId { get; set; }

        /// <summary>
        /// 支付超时时间(以分钟为单位)
        /// </summary>
        [XmlElement("time_out")]
        public string TimeOut { get; set; }
    }
}
