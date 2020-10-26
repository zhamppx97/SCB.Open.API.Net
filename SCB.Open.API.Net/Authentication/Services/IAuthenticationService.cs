using SCB.Open.API.Net.Authentication.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Authentication.Services
{
    public interface IAuthenticationService
    {
        public AuthorizeResponseData GetAuthorize(AuthorizeRequestHeader authorizeRequestHeader);

        public Task<AuthorizeResponseData> GetAuthorizeAsync(AuthorizeRequestHeader authorizeRequestHeader);

        public TokenResponseData GetToken(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody);

        public Task<TokenResponseData> GetTokenAsync(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody);

        public TokenRefreshResponseData GetTokenRefresh(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody);

        public Task<TokenRefreshResponseData> GetTokenRefreshAsync(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody);
    }
}
