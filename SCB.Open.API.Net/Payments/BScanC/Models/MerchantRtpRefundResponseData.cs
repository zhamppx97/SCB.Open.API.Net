
namespace SCB.Open.API.Net.Payments.BScanC.Models
{
    public class MerchantRtpRefundResponseData
    {
        public MerchantRtpRefundStatus status { get; set; }
        public MerchantRtpRefundData data { get; set; }
        public object jsonString { get; set; }
    }

    public class MerchantRtpRefundStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class MerchantRtpRefundData
    {
        public string refundTransactionDateTime { get; set; }
        public string transactionId { get; set; }
        public string partnerTransactionId { get; set; }
    }
}
