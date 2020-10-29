using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Payments.BScanC.Models
{
    public class MerchantRtpRefundRequestBody
    {
        /// <summary>
        /// Required:
        /// Unique Transaction ID from a
        /// </summary>
        [Required]
        public string partnerTransactionID { get; set; }
    }
}
