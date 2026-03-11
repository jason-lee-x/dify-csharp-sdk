using System.Net.Http;
using DifyAI.Interfaces;
using DifyAI.Options;
using Microsoft.Extensions.Options;

namespace DifyAI.Services
{
    internal class DifyAIServiceFactory : IDifyAIServiceFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IOptionsMonitor<DifyAIOptions> _optionsMonitor;

        public DifyAIServiceFactory(IHttpClientFactory httpClientFactory, IOptionsMonitor<DifyAIOptions> optionsMonitor)
        {
            _httpClientFactory = httpClientFactory;
            _optionsMonitor = optionsMonitor;
        }

        public IDifyAIService CreateService(string name)
        {
            var httpClient = _httpClientFactory.CreateClient(name);
            var options = _optionsMonitor.Get(name);
            return new DifyAIService(httpClient, new OptionsWrapper<DifyAIOptions>(options));
        }
    }
}
