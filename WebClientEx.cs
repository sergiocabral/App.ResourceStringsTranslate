using System;
using System.Net;
using System.Text;

namespace ResourceStringsTranslate
{
    public class WebClientEx : WebClient
    {
        static WebClientEx()
        {
            Default = new WebClientEx();
            Default.Encoding = Encoding.UTF8;
            Default.Timeout = 10000;
        }

        public static WebClientEx Default { get; }

        public int Timeout { get; set; } = 60000;

        public WebRequest LastWebRequest { get; private set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            LastWebRequest = base.GetWebRequest(address);
            LastWebRequest.Timeout = Timeout;
            return LastWebRequest;
        }
    }
}