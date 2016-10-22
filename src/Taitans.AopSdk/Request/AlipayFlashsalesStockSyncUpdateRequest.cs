using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.flashsales.stock.sync.update
    /// </summary>
    public class AlipayFlashsalesStockSyncUpdateRequest : IAopRequest<AlipayFlashsalesStockSyncUpdateResponse>
    {
        /// <summary>
        /// 商户的商品id
        /// </summary>
        public string OutProductId { get; set; }

        /// <summary>
        /// 服务窗id
        /// </summary>
        public string PublicId { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public Nullable<long> Stock { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;


		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.flashsales.stock.sync.update";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("out_product_id", this.OutProductId);
            parameters.Add("public_id", this.PublicId);
            parameters.Add("stock", this.Stock);
            return parameters;
        }

        #endregion
    }
}
