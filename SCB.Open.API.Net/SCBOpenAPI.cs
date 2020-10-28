using SCB.Open.API.Net.Authentication.Models;
using SCB.Open.API.Net.Authentication.Services;
using SCB.Open.API.Net.Customer.Information.Models;
using SCB.Open.API.Net.Customer.Information.Services;
using SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models;
using SCB.Open.API.Net.Payments.SCBEasyAppPayment.Services;
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

        #region Payments services
        public class Payments
        {
            public class SCBEasyAppPayment
            {
                private readonly SCBEasyAppPaymentService _scbEasyAppPaymentService = new SCBEasyAppPaymentService();
                /// <summary>
                /// Create your request header deeplink transactions.
                /// </summary>
                public DeepLinkTransactionsRequestHeader CreateDeepLinkTransactionsRequestHeader = new DeepLinkTransactionsRequestHeader();
                /// <summary>
                /// Create your request body deeplink transactions.
                /// </summary>
                public DeepLinkTransactionsRequestBody CreateDeepLinkTransactionsRequestBody = new DeepLinkTransactionsRequestBody();
                /// <summary>
                /// This endpoint creates a transaction record with deeplink URL. Partners who would like to initiate a purchase process to be completed via deeplink integration with partner channel for SCB customer must first log the details of this transaction.
                /// </summary>
                /// <param name="deepLinkTransactionsRequestHeader"></param>
                /// <param name="deepLinkTransactionsRequestBody"></param>
                /// <returns>Creates a transaction record with deeplink URL</returns>
                public DeepLinkTransactionsResponseData GetDeepLinkTransactions(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody)
                {
                    return _scbEasyAppPaymentService.GetDeepLinkTransactions(deepLinkTransactionsRequestHeader, deepLinkTransactionsRequestBody);
                }
                /// <summary>
                /// This endpoint creates a transaction record with deeplink URL. Partners who would like to initiate a purchase process to be completed via deeplink integration with partner channel for SCB customer must first log the details of this transaction.
                /// </summary>
                /// <param name="deepLinkTransactionsRequestHeader"></param>
                /// <param name="deepLinkTransactionsRequestBody"></param>
                /// <returns>Creates a transaction record with deeplink URL</returns>
                public async Task<DeepLinkTransactionsResponseData> GetDeepLinkTransactionsAsync(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody)
                {
                    return await _scbEasyAppPaymentService.GetDeepLinkTransactionsAsync(deepLinkTransactionsRequestHeader, deepLinkTransactionsRequestBody);
                }
            }
        }
        #endregion

        #region Customer Information services
        public class CustomerInfo
        {
            private readonly CustomerInfoService _customerInfoService = new CustomerInfoService();
            /// <summary>
            /// Create your request header customer info.
            /// </summary>
            public CustomerInfoRequestHeader CreateCustomerInfoRequestHeader = new CustomerInfoRequestHeader();
            /// <summary>
            /// This endpoint provides the consented user information to the partner application.
            /// </summary>
            /// <param name="customerInfoRequestHeader">Request Header</param>
            /// <returns>User information to the partner application</returns>
            public CustomerInfoResponseData GetProfile(CustomerInfoRequestHeader customerInfoRequestHeader)
            {
                return _customerInfoService.GetProfile(customerInfoRequestHeader);
            }
            /// <summary>
            /// This endpoint provides the consented user information to the partner application.
            /// </summary>
            /// <param name="customerInfoRequestHeader">Request Header</param>
            /// <returns>User information to the partner application</returns>
            public async Task<CustomerInfoResponseData> GetProfileAsync(CustomerInfoRequestHeader customerInfoRequestHeader)
            {
                return await _customerInfoService.GetProfileAsync(customerInfoRequestHeader);
            }
        }
        #endregion
    }
}
