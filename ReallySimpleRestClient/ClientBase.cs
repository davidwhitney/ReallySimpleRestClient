using ReallySimpleRestClient.Http;
using System;

namespace ReallySimpleRestClient
{
    public abstract class ClientBase : IClient
    {
       
        public IHttpClient HttpClient { get; private set; }

        protected internal ClientConfiguration Configuration { get; private set; }
        public HttpChannel HttpChannel { get; private set; }

        protected ClientBase(ClientConfiguration clientConfiguration, IHttpClient httpClient)
        {
            if(httpClient == null)
            {
                throw new ArgumentNullException("httpClient", "httpClient must not be null to access the api.");
            }

            HttpClient = httpClient;
            HttpClient.ConnectionTimeOut = TimeSpan.FromMinutes(3);

            Configuration = clientConfiguration;

            InitApis(HttpClient, clientConfiguration);
        }

        public void InitApis(IHttpClient httpClient, ClientConfiguration clientConfiguration)
        {
            HttpChannel = new HttpChannel(clientConfiguration, httpClient);
        }

        public void UpdateConfiguration(ClientConfiguration configuration)
        {
            Configuration = configuration;
            InitApis(HttpClient, configuration);
        }
    }
}
