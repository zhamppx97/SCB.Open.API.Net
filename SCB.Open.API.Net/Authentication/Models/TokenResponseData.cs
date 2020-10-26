
namespace SCB.Open.API.Net.Authentication.Models
{
    public class TokenResponseData
    {
        public TokenStatus status { get; set; }
        public TokenData data { get; set; }
        public object jsonString { get; set; }
    }

    public class TokenStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class TokenData
    {
        public string accessToken { get; set; }
        public string tokenType { get; set; }
        public int expiresIn { get; set; }
        public int expiresAt { get; set; }
        public string refreshToken { get; set; }
        public int refreshExpiresIn { get; set; }
        public int refreshExpiresAt { get; set; }
    }
}
