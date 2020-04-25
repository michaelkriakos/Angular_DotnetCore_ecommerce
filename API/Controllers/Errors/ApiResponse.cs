using System;

namespace API.Controllers.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message??GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400=>" a bad request",
                401=>" u r not authorized",
                404=>" resource not found",
                500=>" server erro",
                _=>null
            };
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}