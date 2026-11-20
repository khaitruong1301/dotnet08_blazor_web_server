public class ResponseDataDTO<T> 
{
    public int statusCode { get; set; }
    public string message { get; set; }
    public DateTime dateTime { get; set; }
    public T content { get; set; }
}