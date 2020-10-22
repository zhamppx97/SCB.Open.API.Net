using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Authentication.Models
{
    public class TokenRequestHeader
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
        /// The hash value of the userid, or related user identification value.
        /// If no resourceOwnerId available, use applicationId
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
