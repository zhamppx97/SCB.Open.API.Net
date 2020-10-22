using SCB.Open.API.Net.Authentication.Models;

namespace SCB.Open.API.Net.Authentication.Services
{
    public interface IAuthenticationService
    {
        public string GetAuthorize(AuthorizeRequestHeader authorizeRequestHeader);

        public string GetToken(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody);

        public string GetTokenRefresh(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody);
    }
}
