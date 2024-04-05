namespace JopipediaAPI.Data.Framework.Helpers;

public class MessageResponse
{
    public string Key { get; set; }
    public string Value { get; set; }
}

public class ServiceResponse<T>
{
    public bool IsSuccess { get; private set; }
    public bool IsNotFound { get; private set; }
    public bool IsBadRequest { get; private set; }
    public MessageResponse Message { get; private set; }
    public T? Data { get; private set; }
    
    private ServiceResponse(bool success, bool notFound, bool badRequest, MessageResponse message, T? data)
    {
        IsSuccess = success;
        IsNotFound = notFound;
        IsBadRequest = badRequest;
        Message = message;
        Data = data;
    }
    
    public static ServiceResponse<T> Success(T? data = default)
    {
        return new ServiceResponse<T>(true, false, false, new MessageResponse { Key = "executedSuccessfully", Value = "Executed Successfully" }, data);
    }

    public static ServiceResponse<T> NotFound( string key, string message)
    {
        return new ServiceResponse<T>(false, true, false, new MessageResponse { Key = key, Value = message }, default);
    }

    public static ServiceResponse<T> BadRequest( string key, string message)
    {
        return new ServiceResponse<T>(false, false, true, new MessageResponse { Key = key, Value = message }, default);
    }

}