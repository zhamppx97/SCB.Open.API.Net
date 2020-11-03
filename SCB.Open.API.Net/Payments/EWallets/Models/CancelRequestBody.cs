using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Payments.EWallets.Models
{
    public class CancelRequestBody
    {
        /// <summary>
        /// Required:
        /// Type of QR Code
        /// • "A": Alipay
        /// • "W": WeChatPay
        /// </summary>
        [Required]
        public string tranType { get; set; }
        /// <summary>
        /// Required:
        /// Company ID
        /// Length: Up to 5
        /// For sandbox: It must be number[0 - 9]
        /// </summary>
        [Required]
        public string companyId { get; set; }
        /// <summary>
        /// Required:
        /// Terminal ID
        /// </summary>
        [Required]
        public string terminalId { get; set; }
        /// <summary>
        /// Required:
        /// Unique Merchant Transaction Reference Number
        /// Length: Up to 50
        /// For sandbox: It must start with 'SCB'
        /// </summary>
        [Required]
        public string outTradeNo { get; set; }
    }
}
