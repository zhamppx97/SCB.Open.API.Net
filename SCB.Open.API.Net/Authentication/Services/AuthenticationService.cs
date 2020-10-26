using Newtonsoft.Json;
using RestSharp;
using SCB.Open.API.Net.Authentication.Models;
using SCB.Open.API.Net.Infrastructure;
using SCB.Open.API.Net.Settings;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Authentication.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppSettings _appSettings = new AppSettings();
        private readonly string _remoteServiceBaseUrl;

        public AuthenticationService()
        {
            _remoteServiceBaseUrl = $"{_appSettings.BaseApiUrl}";
        }

        public AuthorizeResponseData GetAuthorize(AuthorizeRequestHeader authorizeRequestHeader)
        {
            var client = new RestClient(OpenAPI.Authentication.Authorize(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", authorizeRequestHeader.ApiKey);
            request.AddHeader("apisecret", authorizeRequestHeader.ApiSecret);
            request.AddHeader("resourceOwnerId", authorizeRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", authorizeRequestHeader.RequestUId);
            request.AddHeader("response-channel", authorizeRequestHeader.ResponseChannel);
            request.AddHeader("endState", authorizeRequestHeader.EndState);
            request.AddHeader("accept-language", authorizeRequestHeader.AcceptLanguage);
            request.AddHeader("applicationId", authorizeRequestHeader.ApplicationId);
            request.AddHeader("redirectOption", authorizeRequestHeader.RedirectOption);
            request.AddHeader("state", authorizeRequestHeader.State);
            request.AddHeader("codeChallenge", authorizeRequestHeader.CodeChallenge);

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<AuthorizeResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<AuthorizeResponseData> GetAuthorizeAsync(AuthorizeRequestHeader authorizeRequestHeader)
        {
            var client = new RestClient(OpenAPI.Authentication.Authorize(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", authorizeRequestHeader.ApiKey);
            request.AddHeader("apisecret", authorizeRequestHeader.ApiSecret);
            request.AddHeader("resourceOwnerId", authorizeRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", authorizeRequestHeader.RequestUId);
            request.AddHeader("response-channel", authorizeRequestHeader.ResponseChannel);
            request.AddHeader("endState", authorizeRequestHeader.EndState);
            request.AddHeader("accept-language", authorizeRequestHeader.AcceptLanguage);
            request.AddHeader("applicationId", authorizeRequestHeader.ApplicationId);
            request.AddHeader("redirectOption", authorizeRequestHeader.RedirectOption);
            request.AddHeader("state", authorizeRequestHeader.State);
            request.AddHeader("codeChallenge", authorizeRequestHeader.CodeChallenge);
            
            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<AuthorizeResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public TokenResponseData GetToken(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody)
        {
            var client = new RestClient(OpenAPI.Authentication.Token(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", tokenRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", tokenRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", tokenRequestHeader.RequestUId);
            request.AddHeader("accept-language", tokenRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(tokenRequestBody));
            
            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<TokenResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<TokenResponseData> GetTokenAsync(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody)
        {
            var client = new RestClient(OpenAPI.Authentication.Token(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", tokenRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", tokenRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", tokenRequestHeader.RequestUId);
            request.AddHeader("accept-language", tokenRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(tokenRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<TokenResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public TokenRefreshResponseData GetTokenRefresh(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody)
        {
            var client = new RestClient(OpenAPI.Authentication.TokenRefresh(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", tokenRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", tokenRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", tokenRequestHeader.RequestUId);
            request.AddHeader("accept-language", tokenRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(tokenRefreshRequestBody));
            
            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<TokenRefreshResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<TokenRefreshResponseData> GetTokenRefreshAsync(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody)
        {
            var client = new RestClient(OpenAPI.Authentication.TokenRefresh(_remoteServiceBaseUrl))
            {
                //Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", tokenRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", tokenRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", tokenRequestHeader.RequestUId);
            request.AddHeader("accept-language", tokenRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(tokenRefreshRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<TokenRefreshResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }
    }
}
