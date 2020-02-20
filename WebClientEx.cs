using System;
using System.Net;
using System.Text;

namespace ResourceStringsTranslate
{
    public class WebClientEx: WebClient
    {
        public static WebClientEx Default { get; }

        static WebClientEx()
        {
            Default = new WebClientEx();
            Default.Encoding = Encoding.UTF8;
            Default.Timeout = 10000;
        }

        public int Timeout { get; set; } = 60000;

        protected override WebRequest GetWebRequest(Uri address)
        {
            var objWebRequest= base.GetWebRequest(address);
            objWebRequest.Timeout = Timeout;
            return objWebRequest;
        }
    }
}