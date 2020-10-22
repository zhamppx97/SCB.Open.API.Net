
namespace SCB.Open.API.Net.Infrastructure
{
    public static class OpenAPI
    {
        public static class Authentication
        {
            public static string Authorize(string baseUri)
            {
                return $"{baseUri}/v2/oauth/authorize";
            }

            public static string Token(string baseUri)
            {
                return $"{baseUri}/v1/oauth/token";
            }

            public static string TokenRefresh(string baseUri)
            {
                return $"{baseUri}/v1/oauth/token/refresh";
            }
        }
    }
}
