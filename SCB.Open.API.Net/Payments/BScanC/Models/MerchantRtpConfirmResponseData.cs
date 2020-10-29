
namespace SCB.Open.API.Net.Payments.BScanC.Models
{
    public class MerchantRtpConfirmResponseData
    {
        public MerchantRtpConfirmStatus status { get; set; }
        public MerchantRtpConfirmData data { get; set; }
        public object jsonString { get; set; }
    }

    public class MerchantRtpConfirmStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class MerchantRtpConfirmData
    {
        public Originaltransaction originalTransaction { get; set; }
        public string partnerTransactionId { get; set; }
        public string transactionId { get; set; }
        public string transactionDateTime { get; set; }
        public string exchangeRate { get; set; }
        public string transactionAmount { get; set; }
        public string transactionCurrency { get; set; }
        public string equivalenceTransactionAmount { get; set; }
        public string equivalenceTransactionCurrency { get; set; }
        public string payerBankCode { get; set; }
        public string payerTepaCode { get; set; }
        public string billerId { get; set; }
        public string reference1 { get; set; }
        public string reference2 { get; set; }
        public string reference3 { get; set; }
        public string slipId { get; set; }
    }

    public class Originaltransaction
    {
        public string messageIdentification { get; set; }
        public string messageNameIdentification { get; set; }
        public string paymentInformationIdentification { get; set; }
    }
}
