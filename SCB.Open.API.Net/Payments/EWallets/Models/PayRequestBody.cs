using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Payments.EWallets.Models
{
    public class PayRequestBody
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
        /// <summary>
        /// Required:
        /// Amount of transaction with the length up to 10 characters including "." e.g. 100, 100.00
        /// </summary>
        [Required]
        public string totalFee { get; set; }
        /// <summary>
        /// Required:
        /// Buyer Identity Code.
        /// The code can be retrieve by reading Customer QR Code on Alipay or WeChatPay Application
        /// </summary>
        [Required]
        public string buyerIdentityCode { get; set; }
    }
}
