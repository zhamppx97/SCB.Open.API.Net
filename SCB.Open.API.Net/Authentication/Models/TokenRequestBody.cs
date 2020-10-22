using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Authentication.Models
{
    public class TokenRequestBody
    {
        /// <summary>
        /// Required:
        /// The unique key of the application that is accessing data on the user's authority
        /// </summary>
        [Required]
        public string applicationKey { get; set; }
        /// <summary>
        /// Required:
        /// The secret key associated to the partner's application
        /// </summary>
        [Required]
        public string applicationSecret { get; set; }
        /// <summary>
        /// Conditional:
        /// Authorization code acquired following the user's grant of consent
        /// Required if your application needs to access APIs that are user specific.
        /// </summary>
        public string authCode { get; set; }
        /// <summary>
        /// Conditional:
        /// Corresponding unique state key for the current session, support for web application only
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// Conditional:
        /// Code challenge secret key of the current session, support for web application only
        /// </summary>
        public string codeChallenge { get; set; }
    }
}
