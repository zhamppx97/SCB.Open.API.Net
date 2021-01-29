using SCB.Open.API.Net.Authentication.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Authentication.Services
{
    public interface IAuthenticationService
    {
        AuthorizeResponseData GetAuthorize(AuthorizeRequestHeader authorizeRequestHeader);
        Task<AuthorizeResponseData> GetAuthorizeAsync(AuthorizeRequestHeader authorizeRequestHeader);
        TokenResponseData GetToken(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody);
        Task<TokenResponseData> GetTokenAsync(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody);
        TokenRefreshResponseData GetTokenRefresh(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody);
        Task<TokenRefreshResponseData> GetTokenRefreshAsync(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody);
    }
}
