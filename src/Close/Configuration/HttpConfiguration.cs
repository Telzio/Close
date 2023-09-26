using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Close.Configuration;

public class HttpConfiguration : HttpConfigurationFactory
{
    private readonly IServiceCollection _serviceCollection;

    public HttpConfiguration(IServiceCollection serviceCollection)
    {
        _serviceCollection = serviceCollection;
    }
    
    internal static void Configure(IServiceCollection serviceCollection, string apiKey, Action<HttpConfiguration> configure = null)
    {
        var config = new HttpConfiguration(serviceCollection);
        configure?.Invoke(config);

        CreateHttpClient(serviceCollection);

        ApiKey = apiKey;
        serviceCollection.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    }
}