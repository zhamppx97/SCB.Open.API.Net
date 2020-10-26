using SCB.Open.API.Net.Authentication.Models;
using SCB.Open.API.Net.Authentication.Services;
using System.Threading.Tasks;

namespace SCB.Open.API.Net
{
    public class SCBOpenAPI
    {
        #region Authentication services
        public class Authentication
        {
            private readonly AuthenticationService _oauthService = new AuthenticationService();
            /// <summary>
            /// Create your request header authorize
            /// </summary>
            public AuthorizeRequestHeader CreateAuthorizeRequestHeader = new AuthorizeRequestHeader();
            /// <summary>
            /// Create your request header token.
            /// </summary>
            public TokenRequestHeader CreateTokenRequestHeader = new TokenRequestHeader();
            /// <summary>
            /// Create your request body token.
            /// </summary>
            public TokenRequestBody CreateTokenRequestBody = new TokenRequestBody();
            /// <summary>
            /// Create your request body token refresh.
            /// </summary>
            public TokenRefreshRequestBody CreateTokenRefreshRequestBody = new TokenRefreshRequestBody();
            /// <summary>
            /// This endpoint authorize whether the application is valid, allow the login to proceed by returning login redirection URL.
            /// </summary>
            /// <param name="authorizeRequestHeader">Request Header</param>
            /// <returns>Authorize</returns>
            public AuthorizeResponseData GetAuthorize(AuthorizeRequestHeader authorizeRequestHeader)
            {
                return _oauthService.GetAuthorize(authorizeRequestHeader);
            }
            /// <summary>
            /// This endpoint authorize whether the application is valid, allow the login to proceed by returning login redirection URL.
            /// </summary>
            /// <param name="authorizeRequestHeader">Request Header</param>
            /// <returns>Authorize</returns>
            public async Task<AuthorizeResponseData> GetAuthorizeAsync(AuthorizeRequestHeader authorizeRequestHeader)
            {
                return await _oauthService.GetAuthorizeAsync(authorizeRequestHeader);
            }
            /// <summary>
            /// This endpoint generates the access token, which is used to access any consented resource of the user on SCB Developer platform.
            /// Required: TokenRequestHeader, TokenRequestBody 
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRequestBody">Request Body</param>
            /// <returns>Access token</returns>
            public TokenResponseData GetToken(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody)
            {
                return _oauthService.GetToken(tokenRequestHeader, tokenRequestBody);
            }
            /// <summary>
            /// This endpoint generates the access token, which is used to access any consented resource of the user on SCB Developer platform.
            /// Required: TokenRequestHeader, TokenRequestBody 
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRequestBody">Request Body</param>
            /// <returns>Access token</returns>
            public async Task<TokenResponseData> GetTokenAsync(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody)
            {
                return await _oauthService.GetTokenAsync(tokenRequestHeader, tokenRequestBody);
            }
            /// <summary>
            /// This endpoint refresh the expired access token, generating a new set of the access token with the same access right as the previously generated prior.
            /// Required: TokenRequestHeader, TokenRefreshRequestBody
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRefreshRequestBody">Request Body</param>
            /// <returns>A new set of the access token</returns>
            public TokenRefreshResponseData GetTokenRefresh(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody)
            {
                return _oauthService.GetTokenRefresh(tokenRequestHeader, tokenRefreshRequestBody);
            }
            /// <summary>
            /// This endpoint refresh the expired access token, generating a new set of the access token with the same access right as the previously generated prior.
            /// Required: TokenRequestHeader, TokenRefreshRequestBody
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRefreshRequestBody">Request Body</param>
            /// <returns>A new set of the access token</returns>
            public async Task<TokenRefreshResponseData> GetTokenRefreshAsync(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody)
            {
                return await _oauthService.GetTokenRefreshAsync(tokenRequestHeader, tokenRefreshRequestBody);
            }
        }
        #endregion
    }
}
