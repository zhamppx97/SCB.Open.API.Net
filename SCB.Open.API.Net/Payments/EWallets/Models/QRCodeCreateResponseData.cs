
namespace SCB.Open.API.Net.Payments.EWallets.Models
{
    public class QRCodeCreateResponseData
    {
        public QRCodeCreateStatus status { get; set; }
        public QRCodeCreateData data { get; set; }
        public object jsonString { get; set; }
    }

    public class QRCodeCreateStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class QRCodeCreateData
    {
        public string codeUrl { get; set; }
        public string prepayId { get; set; }
    }
}
