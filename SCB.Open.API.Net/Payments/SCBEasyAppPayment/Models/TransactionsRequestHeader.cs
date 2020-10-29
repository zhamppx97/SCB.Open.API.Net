using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models
{
    public class TransactionsRequestHeader
    {
        /// <summary>
        /// Conditional:
        /// OAuth token obtained after the user has provided consent and the authorized partner calls the /v1/oauth/token endpoint to retrieve this token
        /// </summary>
        public string Authorization { get; set; }
        /// <summary>
        /// Optional:
        /// The language of the content in the request payload
        /// Values:
        /// - EN(Default)
        /// - TH
        /// </summary>
        public string AcceptLanguage { get; set; }
        /// <summary>
        /// Required:
        /// The hash value of the userid, or your application id value
        /// </summary>
        [Required]
        public string ResourceOwnerId { get; set; }
        /// <summary>
        /// Required:
        /// A unique identifier the client can generate to track the current request call
        /// </summary>
        [Required]
        public string RequestUId { get; set; }
    }
}
