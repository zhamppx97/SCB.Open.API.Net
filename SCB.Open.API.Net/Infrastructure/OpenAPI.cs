
namespace SCB.Open.API.Net.Infrastructure
{
    public static class OpenAPI
    {
        public static class Authentication
        {
            /// <summary>
            /// GET: Authorize
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string Authorize(string baseUri)
            {
                return $"{baseUri}/v2/oauth/authorize";
            }
            /// <summary>
            /// POST: Token
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string Token(string baseUri)
            {
                return $"{baseUri}/v1/oauth/token";
            }
            /// <summary>
            /// POST: Token Refresh
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string TokenRefresh(string baseUri)
            {
                return $"{baseUri}/v1/oauth/token/refresh";
            }
        }

        public static class Payments
        {
            public static class SCBEasyAppPayment
            {
                /// <summary>
                /// POST: Deeplink Transactions
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string DeeplinkTransactions(string baseUri)
                {
                    return $"{baseUri}/​v3/​deeplink/​transactions";
                }
                /// <summary>
                /// GET: Transactions
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string Transactions(string baseUri)
                {
                    return $"{baseUri}/​v2/​transactions/​";
                }
            }

            public static class BScanC
            {
                /// <summary>
                /// POST: Confirm
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string Confirm(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​merchant/​rtp/​confirm";
                }
                /// <summary>
                /// POST: Refund
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string Refund(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​merchant/​rtp/​refund";
                }
            }
        }

        public static class CustomerInfo
        {
            /// <summary>
            /// GET: Customer Profile
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string Profile(string baseUri)
            {
                return $"{baseUri}/​v2/​customers/​profile";
            }
        }
    }
}
