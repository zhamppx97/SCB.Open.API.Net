using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models
{

    public class DeepLinkTransactionsRequestBody
    {
        [Required]
        public string transactionType { get; set; }
        [Required]
        public string[] transactionSubType { get; set; }
        public int sessionValidityPeriod { get; set; }
        public string sesisionValidUntil { get; set; }
        public BillPayment billPayment { get; set; }
        public CreditCardFullAmount creditCardFullAmount { get; set; }
        public InstallmentPaymentPlan installmentPaymentPlan { get; set; }
        public MerchantMetaData merchantMetaData { get; set; }
    }

    public class BillPayment
    {
        [Required]
        public float paymentAmount { get; set; }
        public string accountTo { get; set; }
        [Required]
        public string ref1 { get; set; }
        public string ref2 { get; set; }
        public string ref3 { get; set; }
    }

    public class CreditCardFullAmount
    {
        [Required]
        public string merchantId { get; set; }
        public string terminalId { get; set; }
        [Required]
        public string orderReference { get; set; }
        public float paymentAmount { get; set; }
    }

    public class InstallmentPaymentPlan
    {
        [Required]
        public string merchantId { get; set; }
        public string terminalId { get; set; }
        [Required]
        public string orderReference { get; set; }
        [Required]
        public float paymentAmount { get; set; }
        public string tenor { get; set; }
        public string ippType { get; set; }
        public string prodCode { get; set; }
    }

    public class MerchantMetaData
    {
        public string callbackUrl { get; set; }
        public Merchantinfo merchantInfo { get; set; }
    }

    public class Merchantinfo
    {
        public string name { get; set; }
    }
}
