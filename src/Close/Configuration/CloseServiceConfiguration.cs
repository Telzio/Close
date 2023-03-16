using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Close.Configuration;

public class CloseServiceConfiguration : CloseServiceConfigurationFactory
{
    private readonly IServiceCollection _serviceCollection;

    public CloseServiceConfiguration(IServiceCollection serviceCollection)
    {
        _serviceCollection = serviceCollection;
    }
    
    internal static void Configure(IServiceCollection serviceCollection, string apiKey, Action<CloseServiceConfiguration> configure = null)
    {
        var config = new CloseServiceConfiguration(serviceCollection);
        configure?.Invoke(config);

        CreateHttpClient(serviceCollection);

        ApiKey = apiKey;
        serviceCollection.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    }
}