using System.Net;

namespace Herbzhub.Infrastructure.Helper
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data {  get; set; }
        public HttpStatusCode StatusCode { get; set; }


        public BaseResponse()
        {
            Success = true;
            Message = string.Empty;
            StatusCode = HttpStatusCode.OK;
        }
        
        public BaseResponse(bool success, string message, T data ,HttpStatusCode httpStatusCode)
        {
            Success = success;
            Message = message;
            Data = data;
            StatusCode = httpStatusCode;
        }
    }
}
