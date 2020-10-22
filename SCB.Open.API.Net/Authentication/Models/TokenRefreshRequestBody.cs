using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Authentication.Models
{
    public class TokenRefreshRequestBody
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
        /// Required:
        /// Refresh token of the previously generated access token
        /// </summary>
        [Required]
        public string refreshToken { get; set; }
    }
}
