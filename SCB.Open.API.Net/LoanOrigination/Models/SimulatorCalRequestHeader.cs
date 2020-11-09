using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.LoanOrigination.Models
{
    public class SimulatorCalRequestHeader
    {
        /// <summary>
        /// Required:
        /// Content type of request payload
        /// Required: application/json
        /// </summary>
        [Required]
        public string ContentType { get; set; }
        /// <summary>
        /// Required:
        /// The hash value of the user ID, or related user identification value
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
        /// Conditional:
        /// OAuth token of the user performing the function
        /// </summary>
        public string Authorization { get; set; }
        /// <summary>
        /// Optional:
        /// The language of the content in the response payload
        /// </summary>
        public string AcceptLanguage { get; set; }
    }
}
