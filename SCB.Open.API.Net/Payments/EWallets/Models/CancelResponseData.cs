
namespace SCB.Open.API.Net.Payments.EWallets.Models
{
    public class CancelResponseData
    {
        public CancelStatus status { get; set; }
        public CancelData data { get; set; }
        public object jsonString { get; set; }
    }

    public class CancelStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class CancelData
    {
        public string details { get; set; }
        public string refundId { get; set; }
    }
}
