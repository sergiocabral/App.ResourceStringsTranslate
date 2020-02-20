using System;
using System.Net;

namespace ResourceStringsTranslate
{
    public class WebClientEx: WebClient
    {
        public int Timeout { get; set; } = 60000;

        protected override WebRequest GetWebRequest(Uri address)
        {
            var objWebRequest= base.GetWebRequest(address);
            objWebRequest.Timeout = Timeout;
            return objWebRequest;
        }
    }
}