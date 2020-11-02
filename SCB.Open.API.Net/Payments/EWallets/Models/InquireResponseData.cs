
namespace SCB.Open.API.Net.Payments.EWallets.Models
{
    public class InquireResponseData
    {
        public InquireStatus status { get; set; }
        public InquireData data { get; set; }
        public object jsonString { get; set; }
    }

    public class InquireStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class InquireData
    {
        public string transactionId { get; set; }
        public string amount { get; set; }
        public string mid { get; set; }
        public string ref2 { get; set; }
        public string ref1 { get; set; }
        public string tradeState { get; set; }
        public string nonceStr { get; set; }
        public string tid { get; set; }
        public string exchangeRate { get; set; }
        public string buyerLoginId { get; set; }
        public string timeEnd { get; set; }
        public string cnyAmount { get; set; }
        public string masterTid { get; set; }
        public string ref3 { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public object buyerUserId { get; set; }
        public string addressLine3 { get; set; }
        public string masterMid { get; set; }
    }
}
