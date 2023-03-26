using System.Net;

namespace Magic_Villa.Models
{
    public class APIResponse
    {

        public APIResponse()
        {
            ErrorMessage = new List<string>();
        }
        public HttpStatusCode statusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessage { get; set; }
        public object Result { get; set; }
    }
}
