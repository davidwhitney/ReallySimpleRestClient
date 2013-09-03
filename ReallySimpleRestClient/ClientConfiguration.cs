using System;

namespace ReallySimpleRestClient
{
    public class ClientConfiguration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RootDomain { get; set; }
        public WireDataFormat WireDataFormat { get; set; }
        public bool IsZipSupportedByClient { get; set; }
        public TimeSpan? ConnectionTimeOut { get; set; }

        public ClientConfiguration() : this("http://127.0.0.1/")
        {
        }
        public ClientConfiguration(string rootDomain)
        {
            if (string.IsNullOrEmpty(rootDomain))
            {
                throw new ArgumentNullException("rootDomain", "rootDomain is required.");
            }

            RootDomain = rootDomain;
            IsZipSupportedByClient = false;
        }
    }
}
