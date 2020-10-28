
namespace SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models
{

    public class DeepLinkTransactionsResponseData
    {
        public DeepLinkTransactionsStatus status { get; set; }
        public DeepLinkTransactionsData data { get; set; }
        public object jsonString { get; set; }
    }

    public class DeepLinkTransactionsStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class DeepLinkTransactionsData
    {
        public string transactionId { get; set; }
        public string deeplinkUrl { get; set; }
        public string userRefId { get; set; }
    }

}
