using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Api
{
    public class FlarumApiHandler
    {
        private readonly HttpClientHandler _httpClientHandler =
        new()
        {
            UseCookies = false,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
        };

        public void UseProxyConfiguration(bool useProxy, IWebProxy proxy)
        {
            _httpClientHandler.UseProxy = useProxy;
            _httpClientHandler.Proxy = proxy;
        }


    }
}
