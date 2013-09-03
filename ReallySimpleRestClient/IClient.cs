using ReallySimpleRestClient.Http;

namespace ReallySimpleRestClient
{
    public interface IClient
    {
        IHttpClient HttpClient { get; }
        HttpChannel HttpChannel { get; }
        
        void InitApis(IHttpClient httpClient, ClientConfiguration clientConfiguration);
        void UpdateConfiguration(ClientConfiguration configuration);
    }
}