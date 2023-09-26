namespace Close.Models.Exceptions;

public class CloseException : Exception
{
    public override string Message { get; }
    public HttpResponseMessage HttpResponseMessage { get; }
    public HttpRequestMessage HttpRequestMessage { get; }
    public string JsonPayload { get; }
    public ApiError ApiError { get; }

    public CloseException(string message) : base(message)
    {
        Message = message;
    }
    
    public CloseException(string message, HttpResponseMessage httpResponseMessage) : base(message)
    {
        Message = message;
        HttpResponseMessage = httpResponseMessage;
    }
    
    public CloseException(string message, HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage) : base(message)
    {
        Message = message;
        HttpResponseMessage = httpResponseMessage;
        HttpRequestMessage = httpRequestMessage;
    }
    
    public CloseException(string message, HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage, string jsonPayload) : base(message)
    {
        Message = message;
        HttpResponseMessage = httpResponseMessage;
        HttpRequestMessage = httpRequestMessage;
        JsonPayload = jsonPayload;
    }
    
    public CloseException(string message, HttpResponseMessage httpResponseMessage, HttpRequestMessage httpRequestMessage, string jsonPayload, ApiError apiError) : base(message)
    {
        Message = message;
        HttpResponseMessage = httpResponseMessage;
        HttpRequestMessage = httpRequestMessage;
        JsonPayload = jsonPayload;
        ApiError = apiError;
    }
    
    public CloseException(string message, Exception innerException) : base(message, innerException)
    {
        Message = message;
    }
}