using Microsoft.Extensions.DependencyInjection;

namespace Close.Configuration;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddCloseClient(this IServiceCollection serviceCollection, string apiKey, Action<HttpConfiguration> configure = null)
    {
        HttpConfiguration.Configure(serviceCollection, apiKey, configure);
        return serviceCollection;
    }
}