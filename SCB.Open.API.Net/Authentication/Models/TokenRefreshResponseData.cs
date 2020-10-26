
namespace SCB.Open.API.Net.Authentication.Models
{
    public class TokenRefreshResponseData
    {
        public TokenRefreshStatus status { get; set; }
        public TokenRefreshData data { get; set; }
        public object jsonString { get; set; }
    }

    public class TokenRefreshStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class TokenRefreshData
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
