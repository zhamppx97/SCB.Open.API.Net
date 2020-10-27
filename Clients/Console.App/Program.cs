using SCB.Open.API.Net;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            AuthorizeAsync().Wait();
            TokenAsync().Wait();
            TokenRefreshAsync().Wait();

            Authorize();
            Token();
            TokenRefresh();

            ProfileAsync().Wait();

            Profile();
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
            Console.WriteLine(resultAuthorize.jsonString);
        }

        static async Task AuthorizeAsync()
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

            var resultAuthorize = await auth.GetAuthorizeAsync(auth.CreateAuthorizeRequestHeader);
            Console.WriteLine(resultAuthorize.jsonString);
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
            Console.WriteLine(resultToken.jsonString);
        }

        static async Task TokenAsync()
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

            var resultToken = await auth.GetTokenAsync(auth.CreateTokenRequestHeader, auth.CreateTokenRequestBody);
            Console.WriteLine(resultToken.jsonString);
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
            Console.WriteLine(resultTokenRefresh.jsonString);
        }

        static async Task TokenRefreshAsync()
        {
            SCBOpenAPI.Authentication auth = new SCBOpenAPI.Authentication();

            auth.CreateTokenRequestHeader.ContentType = "application/json";
            auth.CreateTokenRequestHeader.ResourceOwnerId = "<Your API Key>";
            auth.CreateTokenRequestHeader.RequestUId = Guid.NewGuid().ToString();
            auth.CreateTokenRequestHeader.AcceptLanguage = "EN";

            auth.CreateTokenRefreshRequestBody.applicationKey = "<Your API Key>";
            auth.CreateTokenRefreshRequestBody.applicationSecret = "<Your API Secret>";
            auth.CreateTokenRefreshRequestBody.refreshToken = "<Your token for refresh>";

            var resultTokenRefresh = await auth.GetTokenRefreshAsync(auth.CreateTokenRequestHeader, auth.CreateTokenRefreshRequestBody);
            Console.WriteLine(resultTokenRefresh.jsonString);
        }

        static void Profile()
        {
            SCBOpenAPI.CustomerInfo customerInfo = new SCBOpenAPI.CustomerInfo();

            customerInfo.CreateCustomerInfoRequestHeader.Authorization = "<Your Access Token>";
            customerInfo.CreateCustomerInfoRequestHeader.ResourceOwnerId = "<The value of resourceOwnerId from the response header of /v1/oauth/token>";
            customerInfo.CreateCustomerInfoRequestHeader.RequestUId = Guid.NewGuid().ToString();
            customerInfo.CreateCustomerInfoRequestHeader.AcceptLanguage = "EN";

            var resultProfile = customerInfo.GetProfile(customerInfo.CreateCustomerInfoRequestHeader);
            Console.WriteLine(resultProfile.jsonString);
        }

        static async Task ProfileAsync()
        {
            SCBOpenAPI.CustomerInfo customerInfo = new SCBOpenAPI.CustomerInfo();

            customerInfo.CreateCustomerInfoRequestHeader.Authorization = "<Your Access Token>";
            customerInfo.CreateCustomerInfoRequestHeader.ResourceOwnerId = "<The value of resourceOwnerId from the response header of /v1/oauth/token>";
            customerInfo.CreateCustomerInfoRequestHeader.RequestUId = Guid.NewGuid().ToString();
            customerInfo.CreateCustomerInfoRequestHeader.AcceptLanguage = "EN";

            var resultProfile = await customerInfo.GetProfileAsync(customerInfo.CreateCustomerInfoRequestHeader);
            Console.WriteLine(resultProfile.jsonString);
        }
    }
}
