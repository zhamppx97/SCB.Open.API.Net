
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
                public static string Transactions(string baseUri, string transactionId)
                {
                    return $"{baseUri}/​v2/​transactions/{transactionId}​";
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

            /// <summary>
            /// Alipay or WeChatPay
            /// </summary>
            public class EWallets
            {
                /// <summary>
                /// POST: QR Code Create
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string QRCodeCreate(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​ewallets/​qrcode/​create";
                }
                /// <summary>
                /// POST: Inquire
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string Inquire(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​ewallets/​inquire";
                }
                /// <summary>
                /// POST: Cancel
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string Cancel(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​ewallets/​cancel";
                }
                /// <summary>
                /// POST: Refund
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string Refund(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​ewallets/​refund";
                }
                /// <summary>
                /// POST: QR Code Cancel
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string QRCodeCancel(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​ewallets/​qrcode/​cancel";
                }
                /// <summary>
                /// POST: Pay
                /// </summary>
                /// <param name="baseUri">Base uri</param>
                /// <returns>Route API Url</returns>
                public static string Pay(string baseUri)
                {
                    return $"{baseUri}/​v1/​payment/​ewallets/​pay";
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
