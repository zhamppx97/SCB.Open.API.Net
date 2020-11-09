
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

        public static class LoanOrigination
        {
            /// <summary>
            /// POST: Calculate for loan
            /// /​v1/​loanorigination/​simulator/​calculate
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string SimulatorCalculate(string baseUri)
            {
                return $"{baseUri}/​v1/​loanorigination/​simulator/​calculate";
            }

            /// <summary>
            /// POST: Requests loan application initiate
            /// /​v1/​loanorigination/​applications
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string InitiateApplications(string baseUri)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications";
            }

            /// <summary>
            /// GET: Single application
            /// /​v1/​loanorigination/​applications/​{applicationId}
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <param name="applicationId">Application Id</param>
            /// <returns>Route API Url</returns>
            public static string SingleApplications(string baseUri, string applicationId)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications/​{applicationId}";
            }

            /// <summary>
            /// PUT: Updates an existing loan application
            /// /​v1/​loanorigination/​applications/​{applicationId}
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <param name="applicationId">Application Id</param>
            /// <returns>Route API Url</returns>
            public static string UpdateApplications(string baseUri, string applicationId)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications/​{applicationId}";
            }

            /// <summary>
            /// POST: Updates the documents attached to an existing loan application
            /// /​v1/​loanorigination/​applications/​{applicationId}/​documents
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <param name="applicationId">Application Id</param>
            /// <returns>Route API Url</returns>
            public static string UpdateDocuments(string baseUri, string applicationId)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications/​{applicationId}/​documents";
            }

            /// <summary>
            /// GET: The list of documents that the user uploaded and attached to his/her loan application
            /// /​v1/​loanorigination/​applications/​{applicationId}/​documents
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <param name="applicationId">Application Id</param>
            /// <returns>Route API Url</returns>
            public static string ListDocuments(string baseUri, string applicationId)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications/​{applicationId}/​documents";
            }

            /// <summary>
            /// DELETE: Deletes an uploaded document record
            /// /​v1/​loanorigination/​applications/​{applicationId}/​documents/​{documentId}
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <param name="applicationId">Application Id</param>
            /// <param name="documentId">Document Id</param>
            /// <returns>Route API Url</returns>
            public static string DeleteDocuments(string baseUri, string applicationId, string documentId)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications/​{applicationId}/​documents/​{documentId}";
            }

            /// <summary>
            /// POST: Enables a user to submit his/her loan application
            /// /​v1/​loanorigination/​applications/​submit
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string ApplicationsSubmit(string baseUri)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications/​submit";
            }

            /// <summary>
            /// POST: Cancels a loan application
            /// /​v1/​loanorigination/​applications/​cancel
            /// </summary>
            /// <param name="baseUri">Base uri</param>
            /// <returns>Route API Url</returns>
            public static string ApplicationsCancel(string baseUri)
            {
                return $"{baseUri}/​v1/​loanorigination/​applications/​cancel";
            }
        }
    }
}
