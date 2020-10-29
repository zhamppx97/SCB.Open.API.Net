
namespace SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models
{
    public class TransactionsResponseData
    {
        public TransactionsStatus status { get; set; }
        public TransactionsData data { get; set; }
        public object jsonString { get; set; }
    }

    public class TransactionsStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class TransactionsData
    {
        public string transactionId { get; set; }
        public string userRefId { get; set; }
        public string transactionType { get; set; }
        public string[] transactionSubType { get; set; }
        public string transactionMethod { get; set; }
        public string accountFrom { get; set; }
        public float paidAmount { get; set; }
        public TransactionsBillPayment billPayment { get; set; }
        public TransactionsCreditCardFullAmount creditCardFullAmount { get; set; }
        public TransactionsInstallmentPaymentPlan installmentPaymentPlan { get; set; }
        public string partnerId { get; set; }
        public string partnerName { get; set; }
        public int sessionValidityPeriod { get; set; }
        public string createdTimestamp { get; set; }
        public string updatedTimestamp { get; set; }
        public int statusCode { get; set; }
        public TransactionsMerchantMetaData merchantMetaData { get; set; }
    }

    public class TransactionsBillPayment
    {
        public float paymentAmount { get; set; }
        public string accountTo { get; set; }
        public string ref1 { get; set; }
        public string ref2 { get; set; }
        public string ref3 { get; set; }
    }

    public class TransactionsCreditCardFullAmount
    {
        public string merchantId { get; set; }
        public string terminalId { get; set; }
        public string orderReference { get; set; }
    }

    public class TransactionsInstallmentPaymentPlan
    {
        public string merchantId { get; set; }
        public string terminalId { get; set; }
        public string orderReference { get; set; }
        public string tenor { get; set; }
        public string ippType { get; set; }
        public string prodCode { get; set; }
    }

    public class TransactionsMerchantMetaData
    {
        public string deeplinkUrl { get; set; }
        public string callbackUrl { get; set; }
        public object[] paymentInfo { get; set; }
    }
}
