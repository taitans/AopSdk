using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titans.AopSdk.Tests.Entities
{
    public class Create
    {
        /// <summary>
        /// 【必须】商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复 示例值：20150320010101001
        /// </summary>
        public string out_trade_no { get; set; }

        /// <summary>
        /// 【可选】卖家支付宝用户ID。 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        public string seller_id { get; set; }

        /// <summary>
        /// 【必须】订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000] 如果同时传入了【打折金额】，【不可打折金额】，【订单总金额】三者，则必须满足如下条件：【订单总金额】=【打折金额】+【不可打折金额】
        /// </summary>
        public double total_amount { get; set; }

        /// <summary>
        /// 【可选】可打折金额. 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000] 如果该值未传入，但传入了【订单总金额】，【不可打折金额】则该值默认为【订单总金额】-【不可打折金额】
        /// </summary>
        public double discountable_amount { get; set; }

        /// <summary>
        /// 【可选】不可打折金额. 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000] 如果该值未传入，但传入了【订单总金额】,【打折金额】，则该值默认为【订单总金额】-【打折金额】
        /// </summary>
        public double undiscountable_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string subject { get; set; }

        public string buyer_logon_id { get; set; }

    }
}
