using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    public class AlipayMobilePublicMultiMediaDownloadRequest : IAopRequest<AlipayMobilePublicMultiMediaDownloadResponse>
    {

        public string BizContent { get; set; }
        public Stream stream { set; get; }

        #region IAopRequest Members
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private bool needEncrypt = false;


      public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

   
      public  bool GetNeedEncrypt()
        {
            return this.needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return this.notifyUrl;
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return this.apiVersion;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return this.terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return this.terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.mobile.public.multimedia.download";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
