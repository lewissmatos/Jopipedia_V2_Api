namespace JopipediaAPI.Data.Framework.Helpers;

public class MessageResponse
{
    public string Key { get; set; } = "successfully";

    public bool IsSuccess { get; set; } = true;
    public string Value { get; set; } = "Successfully";
}
public class MetaResponse
{
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; } 
    public int TotalCount { get; set; }
    
    public MetaResponse(int currentPage, int totalPages, int totalCount)
    {
        CurrentPage = currentPage;
        TotalPages = totalPages;
        TotalCount = totalCount;
    }
}

public class ServiceResponse<T>
{
    public bool IsSuccess { get; private set; }
    public bool IsNotFound { get; private set; }
    public bool IsBadRequest { get; private set; }
    public MessageResponse Message { get; private set; }
    public T? Data { get; private set; }
    public MetaResponse? Meta { get; private set; }
    
    private ServiceResponse(bool success, bool notFound, bool badRequest, MessageResponse message, T? data, MetaResponse meta = default)
    {
        IsSuccess = success;
        IsNotFound = notFound;
        IsBadRequest = badRequest;
        Message = message;
        Data = data;
        Meta = meta;
    }
    
    public static ServiceResponse<T> Success(T? data = default, MetaResponse meta = default, MessageResponse message = default)
    {
        return new ServiceResponse<T>(true, false, false, message, data, meta);
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