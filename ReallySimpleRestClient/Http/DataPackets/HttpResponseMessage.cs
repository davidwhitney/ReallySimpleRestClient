using System;
using System.Collections.Generic;

namespace ReallySimpleRestClient.Http.DataPackets
{
    public class HttpResponseMessage
    {
        public HttpContent Content { get; set; }
        public string Method { get; set; }
        public ICollection<object> Properties { get; set; }
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public Uri Uri { get; set; }

        public HttpResponseMessage()
        {
            Content = new HttpContent();
            Properties = new List<object>();
        }
    }
}
