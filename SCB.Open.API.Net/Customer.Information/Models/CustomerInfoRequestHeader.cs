using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Customer.Information.Models
{
    public class CustomerInfoRequestHeader
    {
        /// <summary>
        /// Required:
        /// OAuth token obtained after the user has provided consent and the authorized partner calls the /v1/oauth/token endpoint to retrieve this token
        /// </summary>
        [Required]
        public string Authorization { get; set; }
        /// <summary>
        /// Required:
        /// The hash value of the userid. Use the value of resourceOwnerId from the response header of /v1/oauth/token
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
        /// The language of the content in the response payload
        /// Values:
        /// - EN(Default)
        /// - TH
        /// </summary>
        public string AcceptLanguage { get; set; }
    }
}
