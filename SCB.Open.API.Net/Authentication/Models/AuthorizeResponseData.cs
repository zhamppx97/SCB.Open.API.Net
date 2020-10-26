
namespace SCB.Open.API.Net.Authentication.Models
{
    public class AuthorizeResponseData
    {
        public AuthorizeStatus status { get; set; }
        public AuthorizeData data { get; set; }
        public object jsonString { get; set; }
    }

    public class AuthorizeStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class AuthorizeData
    {
        public string callbackUrl { get; set; }
    }
}
