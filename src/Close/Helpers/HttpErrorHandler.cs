using System.Net.Http.Json;
using System.Text.Json;
using Close.Models.Exceptions;

namespace Close.Helpers;

public static class HttpErrorHandler
{
    public static async Task HandleErrorResponseAsync(this HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage, CancellationToken ct)
    {
        if (!httpResponseMessage.IsSuccessStatusCode)
        {
            string payload = null;
            if (httpRequestMessage.Content?.Headers.ContentType?.MediaType == "application/json")
            {
                payload = await httpRequestMessage.Content.ReadAsStringAsync(ct);
            }

            var responseString = await httpResponseMessage.Content.ReadAsStringAsync(ct);

            if (httpResponseMessage.Content.Headers.ContentType?.MediaType == "application/json" && !string.IsNullOrEmpty(responseString))
            {
                var errorResponse = JsonSerializer.Deserialize<ApiError>(responseString);
                throw new CloseException(errorResponse.Error ?? httpResponseMessage.ReasonPhrase, httpResponseMessage, httpRequestMessage, payload, errorResponse);
            }
            
            throw new CloseException(string.IsNullOrEmpty(responseString) ? httpResponseMessage.ReasonPhrase : responseString, httpResponseMessage, httpRequestMessage, payload);
        }
    }
}