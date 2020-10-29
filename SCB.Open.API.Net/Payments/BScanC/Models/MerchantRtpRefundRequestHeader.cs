using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Payments.BScanC.Models
{
    public class MerchantRtpRefundRequestHeader
    {
        /// <summary>
        /// Required:
        /// Content type of request payload
        /// Value:
        /// - application/json
        /// </summary>
        [Required]
        public string ContentType { get; set; }
        /// <summary>
        /// Required:
        /// OAuth token obtained after the user has provided consent and the authorized partner calls the /v1/oauth/token endpoint to retrieve this token
        /// </summary>
        [Required]
        public string Authorization { get; set; }
        /// <summary>
        /// Required:
        /// The system identifier, use the value of apikey
        /// </summary>
        [Required]
        public string ResourceOwnerId { get; set; }
        /// <summary>
        /// Required:
        /// A unique identifier the client can generate to track the current request call
        /// </summary>
        [Required]
        public string RequestUId { get; set; }
        /// <summary>
        /// Optional:
        /// The language of the content in the request payload
        /// Values:
        /// - EN(Default)
        /// - TH
        /// </summary>
        public string AcceptLanguage { get; set; }
    }
}
