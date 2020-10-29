using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Payments.BScanC.Models
{
    public class MerchantRtpConfirmRequestBody
    {
        /// <summary>
        /// Required:
        /// The B Scan C QR Code data read from Mobile Banking Application
        /// </summary>
        [Required]
        public string qrData { get; set; }
        /// <summary>
        /// Required:
        /// Biller ID Length: 15
        /// </summary>
        [Required]
        public string payeeBillerId { get; set; }
        /// <summary>
        /// Required:
        /// Transaction Amount Format in decimal (15,2)
        /// </summary>
        [Required]
        public string transactionAmount { get; set; }
        /// <summary>
        /// Required:
        /// Reference code 1 Length: up to 20 Data Type: [AZ09] English capital letter and number only.
        /// </summary>
        [Required]
        public string reference1 { get; set; }
        /// <summary>
        /// Required:
        /// Conditional
        /// Reference code 2 is required when Biller profile is set to 2 references
        /// Length: up to 20
        /// Data Type: [AZ09] English capital letter and number only.
        /// </summary>
        [Required]
        public string reference2 { get; set; }
        /// <summary>
        /// Required:
        /// Conditional
        /// Reference code 3 is required to identify end point for receiving payment confirmation
        /// Format: Prefix + reference 3 , example : SCB1234
        /// Length: up to 20
        /// Data Type: [AZ09] English capital letter and number only.
        /// </summary>
        [Required]
        public string reference3 { get; set; }
        /// <summary>
        /// Required:
        /// Unique Transaction ID from a partner Format: Biller ID 15 char + random 20 alphanumerics in upper case
        /// </summary>
        [Required]
        public string partnerTransactionId { get; set; }
        /// <summary>
        /// Optional:
        /// Terminal ID
        /// </summary>
        public string payeeTerminalNo { get; set; }
    }
}
