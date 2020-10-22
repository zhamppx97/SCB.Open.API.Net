using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Authentication.Models
{
    public class AuthorizeRequestHeader
    {
        /// <summary>
        /// Required:
        /// API authorization key respective to each partner obtained from partner onboarding process
        /// </summary>
        [Required]
        public string ApiKey { get; set; }
        /// <summary>
        /// Required:
        /// API authorization secret obtained from partner onboarding process
        /// </summary>
        [Required]
        public string ApiSecret { get; set; }
        /// <summary>
        /// Required:
        /// The hash value of the userid, or related user identification value. If no resourceOwnerId available, use applicationId
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
        /// Required:
        /// Channel to present the login interface to the user
        /// Value:
        /// - mobile
        /// </summary>
        [Required]
        public string ResponseChannel { get; set; }
        /// <summary>
        /// Required:
        /// End of authentication flow redirection method to the partner application
        /// Values:
        /// - mobile_app: Redirect back to 3rd party mobile application
        /// - mobile_web: Redirect back to 3rd party web page natively on the mobile phone browser
        /// </summary>
        [Required]
        public string EndState { get; set; }
        /// <summary>
        /// Optional:
        /// The language of the content in the response payload
        /// Values:
        /// - EN(Default)
        /// - TH
        /// </summary>
        public string AcceptLanguage { get; set; }
        /// <summary>
        /// Optional:
        /// API key of the application when the caller is the authorizer
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary>
        /// Optional:
        /// Key of the alternative callback url that is registered to the specified endState
        /// </summary>
        public string RedirectOption { get; set; }
        /// <summary>
        /// Conditional:
        /// Corresponding unique state key for the current session, support for web application only
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Conditional:
        /// Code challenge secret key of the current session, support for web application only
        /// </summary>
        public string CodeChallenge { get; set; }
    }
}
