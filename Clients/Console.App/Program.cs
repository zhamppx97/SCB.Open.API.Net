using SCB.Open.API.Net;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Authorize();
            Token();
            TokenRefresh();
        }

        static void Authorize()
        {
            SCBOpenAPI.Authentication auth = new SCBOpenAPI.Authentication();

            auth.CreateAuthorizeRequestHeader.ApiKey = "<Your API Key>";
            auth.CreateAuthorizeRequestHeader.ApiSecret = "<Your API Secret>";
            auth.CreateAuthorizeRequestHeader.ResourceOwnerId = "<Your API Key>";
            auth.CreateAuthorizeRequestHeader.RequestUId = Guid.NewGuid().ToString();
            auth.CreateAuthorizeRequestHeader.ResponseChannel = "mobile";
            auth.CreateAuthorizeRequestHeader.EndState = "mobile_web";
            auth.CreateAuthorizeRequestHeader.AcceptLanguage = "EN";
            auth.CreateAuthorizeRequestHeader.ApplicationId = null;
            auth.CreateAuthorizeRequestHeader.RedirectOption = null;
            auth.CreateAuthorizeRequestHeader.State = null;
            auth.CreateAuthorizeRequestHeader.CodeChallenge = null;

            var resultAuthorize = auth.GetAuthorize(auth.CreateAuthorizeRequestHeader);
            Console.WriteLine(resultAuthorize);
        }

        static void Token()
        {
            SCBOpenAPI.Authentication auth = new SCBOpenAPI.Authentication();
            
            auth.CreateTokenRequestHeader.ContentType = "application/json";
            auth.CreateTokenRequestHeader.ResourceOwnerId = "<Your API Key>";
            auth.CreateTokenRequestHeader.RequestUId = Guid.NewGuid().ToString();
            auth.CreateTokenRequestHeader.AcceptLanguage = "EN";

            auth.CreateTokenRequestBody.applicationKey = "<Your API Key>";
            auth.CreateTokenRequestBody.applicationSecret = "<Your API Secret>";
            auth.CreateTokenRequestBody.authCode = null;
            auth.CreateTokenRequestBody.state = null;
            auth.CreateTokenRequestBody.codeChallenge = null;

            var resultToken = auth.GetToken(auth.CreateTokenRequestHeader, auth.CreateTokenRequestBody);
            Console.WriteLine(resultToken);
        }

        static void TokenRefresh()
        {
            SCBOpenAPI.Authentication auth = new SCBOpenAPI.Authentication();

            auth.CreateTokenRequestHeader.ContentType = "application/json";
            auth.CreateTokenRequestHeader.ResourceOwnerId = "<Your API Key>";
            auth.CreateTokenRequestHeader.RequestUId = Guid.NewGuid().ToString();
            auth.CreateTokenRequestHeader.AcceptLanguage = "EN";

            auth.CreateTokenRefreshRequestBody.applicationKey = "<Your API Key>";
            auth.CreateTokenRefreshRequestBody.applicationSecret = "<Your API Secret>";
            auth.CreateTokenRefreshRequestBody.refreshToken = "<Your token for refresh>";

            var resultTokenRefresh = auth.GetTokenRefresh(auth.CreateTokenRequestHeader, auth.CreateTokenRefreshRequestBody);
            Console.WriteLine(resultTokenRefresh);
        }
    }
}
