
namespace SCB.Open.API.Net.Payments.EWallets.Models
{
    public class RefundResponseData
    {
        public RefundStatus status { get; set; }
        public RefundData data { get; set; }
        public object jsonString { get; set; }
    }

    public class RefundStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class RefundData
    {
        public string details { get; set; }
        public string refundId { get; set; }
    }
}
