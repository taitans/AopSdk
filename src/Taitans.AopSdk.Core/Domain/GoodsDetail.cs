using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace Taitans.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsDetail : AopObject
    {
        /// <summary>
        /// 支付宝定义的统一商品编号
        /// </summary>
        [JsonProperty("alipay_goods_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonProperty("goods_category", NullValueHandling = NullValueHandling.Ignore)]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品的编号
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价，单位为元
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [JsonProperty("show_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowUrl { get; set; }
    }
}
