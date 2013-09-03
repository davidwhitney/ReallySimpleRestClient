using System;
using ReallySimpleRestClient.Http.DataPackets;

namespace ReallySimpleRestClient.Http
{
    public interface IHttpClient : IHttpClientAsync
    {
        HttpResponseMessage Send(HttpRequestMessage httpRequestMessage);
        void AddHeader(string key, string value);
        HttpResponseMessage Send(string method, Uri uri, byte[] postData, string contentType);
        HttpResponseMessage Send(string method, Uri uri, HttpContent postData);
        TimeSpan? ConnectionTimeOut { get; set; }
    }
}