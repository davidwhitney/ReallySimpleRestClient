﻿using System;
using System.Collections.Generic;

namespace ReallySimpleRestClient.Http.DataPackets
{
    public class HttpRequestMessage
    {
        public HttpContent Content { get; set; }
        public string Method { get; set; }
        public ICollection<object> Properties { get; set; }
        public Uri Uri { get; set; }
        public string AcceptContentType { get; set; }

        public HttpRequestMessage()
        {
            Content = new HttpContent();
            Properties = new List<object>();
        }

        public HttpRequestMessage(string method, Uri uri):this()
        {
            Method = method;
            Uri = uri;
        }
    }
}