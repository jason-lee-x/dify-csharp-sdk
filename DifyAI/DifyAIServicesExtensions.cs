using DifyAI;
using DifyAI.Interfaces;
using DifyAI.Services;
using DifyAI.Options;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DifyAIServicesExtensions
    {
        public static IHttpClientBuilder AddDifyAIService(this IServiceCollection services)
        {
            return services.AddDifyAIService(_ => { });
        }

        public static IHttpClientBuilder AddDifyAIService(this IServiceCollection services, Action<DifyAIOptions> configure)
        {
            services.Configure(configure);

            return services.AddHttpClient<IDifyAIService, DifyAIService>()
                .ConfigureHttpClient((provider, httpClient) =>
                {
                    var options = provider.GetService<IOptions<DifyAIOptions>>().Value;
                    httpClient.AddAuthorization(options.DefaultApiKey, options.BaseDomain);
                })
                .AddTypedClient((httpClient, provider) =>
                {
                    var options = provider.GetService<IOptions<DifyAIOptions>>();
                    return new DifyAIService(httpClient, options);
                });
        }

        /// <summary>
        /// 以指定名称注册一个 DifyAI 服务，可通过 IDifyAIServiceFactory.GetService(name) 获取对应实例
        /// </summary>
        public static IServiceCollection AddDifyAIService(this IServiceCollection services, string name, Action<DifyAIOptions> configure)
        {
            services.Configure(name, configure);

            services.AddHttpClient(name)
                .ConfigureHttpClient((provider, httpClient) =>
                {
                    var options = provider.GetRequiredService<IOptionsMonitor<DifyAIOptions>>().Get(name);
                    httpClient.AddAuthorization(options.DefaultApiKey, options.BaseDomain);
                });

            services.TryAddSingleton<IDifyAIServiceFactory, DifyAIServiceFactory>();

            return services;
        }
    }
}
