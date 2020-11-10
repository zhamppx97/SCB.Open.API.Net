using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.LoanOrigination.Models
{
    public class InitiateApplicationsRequestBody
    {
        public InitiateApplicationsLoan loan { get; set; }
    }

    public class InitiateApplicationsLoan
    {
        /// <summary>
        /// Required:
        /// Product type
        /// </summary>
        [Required]
        public string productIntent { get; set; }
    }
}
