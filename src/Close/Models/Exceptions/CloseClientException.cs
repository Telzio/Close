namespace Close.Models.Exceptions;

public class CloseClientException : Exception
{
    public override string Message { get; }
    public HttpResponseMessage HttpResponseMessage { get; }

    public CloseClientException(string message) : base(message)
    {
        Message = message;
    }
    
    public CloseClientException(string message, HttpResponseMessage httpResponseMessage) : base(message)
    {
        Message = message;
        HttpResponseMessage = httpResponseMessage;
    }
    
    public CloseClientException(string message, Exception innerException) : base(message, innerException)
    {
        Message = message;
    }
}