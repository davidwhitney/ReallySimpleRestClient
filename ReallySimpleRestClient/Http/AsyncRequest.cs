using System;
using System.Net;
using ReallySimpleRestClient.Http.DataPackets;

namespace ReallySimpleRestClient.Http
{
    public class AsyncRequest
    {
        public byte[] RawPostData { get; set; }
        public string RawPostDataContentType { get; set; }
        public Action<HttpResponseMessage> HttpClientCallback { get; set; }
        public HttpWebRequest WebRequest { get; set; }
        public HttpContent PostData { get; set; }
    }
}