
namespace SCB.Open.API.Net.Payments.EWallets.Models
{
    public class QRCodeCancelResponseData
    {
        public QRCodeCancelStatus status { get; set; }
        public object jsonString { get; set; }
    }

    public class QRCodeCancelStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }
}
