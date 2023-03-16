using System.Net.Http.Headers;
using System.Text;
using Close.Models.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;

namespace Close.Configuration;

public abstract class CloseServiceConfigurationFactory 
{
    protected static string ApiBaseAddress { get; set; } = "https://api.close.com/api/v1/";
    protected static string ApiKey;
    
    protected static void CreateHttpClient(IServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<ICloseClient, CloseClient>(c =>
            {
                c.BaseAddress = new Uri(ApiBaseAddress);
                c.DefaultRequestHeaders.Authorization = BuildAuthorizationHeader(ApiKey);
                c.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Close API Client for ASP.NET Core");
            })
            .SetHandlerLifetime(TimeSpan.FromMinutes(5))
            .AddPolicyHandler(_ => HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(
                    retryCount: 10,
                    sleepDurationProvider: attempt => TimeSpan.FromSeconds(0.1 * Math.Pow(2, attempt)), // Back off!  2, 4, 8, 16 etc times 1/4-second
                    
                    onRetry: (e, calculatedWaitDuration) =>
                    {
                        // log.LogWarning($"Waiting {(calculatedWaitDuration.Milliseconds)}ms after receiving HTTP {e.Result.StatusCode} from DIDWW API: {e.Exception.Message}", e.Exception, new
                        // {
                        //     reason_phrase = e.Result.ReasonPhrase,
                        //     http_status_code = e.Result.StatusCode
                        // });
                    }));
        
        // if (ShouldRegisterType<TImplementation>())
        //     _serviceCollection.TryAddSingleton<TImplementation>();
        // return serviceFactory => ((ServiceProviderSlackServiceProvider) serviceFactory).GetRequiredService<TImplementation>();
    }
    
    private static AuthenticationHeaderValue BuildAuthorizationHeader(string apiKey)
    {
        if (string.IsNullOrEmpty(apiKey))
            throw new CloseClientException("API key missing");
            
        var byteArray = Encoding.ASCII.GetBytes($"{apiKey}:");
        var base64 = Convert.ToBase64String(byteArray);
        return new AuthenticationHeaderValue("Basic", base64);
    }
}