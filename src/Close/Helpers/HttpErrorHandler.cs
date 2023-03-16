using System.Net.Http.Json;
using Close.Models.Exceptions;

namespace Close.Helpers;

public static class HttpErrorHandler
{
    public static async Task HandleErrorResponseAsync(this HttpResponseMessage httpResponseMessage)
    {
        if (!httpResponseMessage.IsSuccessStatusCode)
        {
            if (httpResponseMessage.Content.Headers.ContentType?.MediaType == "application/json")
            {
                var errorResponse = await httpResponseMessage.Content.ReadFromJsonAsync<ErrorResponse>();
                if (!string.IsNullOrEmpty(errorResponse?.Error))
                {
                    throw new CloseClientException(errorResponse.Error, httpResponseMessage);
                }
            }

            try
            {
                httpResponseMessage.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                throw new CloseClientException(e.Message, httpResponseMessage);
            }
            
        }
    }
}