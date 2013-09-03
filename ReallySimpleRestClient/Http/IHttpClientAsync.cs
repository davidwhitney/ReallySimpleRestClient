using System;
using ReallySimpleRestClient.Http.DataPackets;

namespace ReallySimpleRestClient.Http
{
    public interface IHttpClientAsync: IDisposable
    {
        void SendAsync(HttpRequestMessage httpRequestMessage, Action<HttpResponseMessage> httpClientCallback);
        void SendAsync(string method, Uri uri, byte[] postData, string contentType, Action<HttpResponseMessage> httpClientCallback);
        void SendAsync(string method, Uri uri, HttpContent postData, Action<HttpResponseMessage> httpClientCallback);
    }
}