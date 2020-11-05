using SCB.Open.API.Net.Payments.EWallets.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.EWallets.Services
{
    public interface IEWalletsService
    {
        public QRCodeCreateResponseData GetQRCodeCreate(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody);
        public Task<QRCodeCreateResponseData> GetQRCodeCreateAsync(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody);
        public InquireResponseData GetInquire(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody);
        public Task<InquireResponseData> GetInquireAsync(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody);
        public CancelResponseData GetCancel(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody);
        public Task<CancelResponseData> GetCancelAsync(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody);
        public RefundResponseData GetRefund(RefundRequestHeader refundRequestHeader, RefundRequestBody refundRequestBody);
        public Task<RefundResponseData> GetRefundAsync(RefundRequestHeader refundRequestHeader, RefundRequestBody refundRequestBody);
        public QRCodeCancelResponseData GetQRCodeCancel(QRCodeCancelRequestHeader qRCodeCancelRequestHeader, QRCodeCancelRequestBody qRCodeCancelRequestBody);
        public Task<QRCodeCancelResponseData> GetQRCodeCancelAsync(QRCodeCancelRequestHeader qRCodeCancelRequestHeader, QRCodeCancelRequestBody qRCodeCancelRequestBody);
        public PayResponseData GetPay(PayRequestHeader payRequestHeader, PayRequestBody payRequestBody);
        public Task<PayResponseData> GetPayAsync(PayRequestHeader payRequestHeader, PayRequestBody payRequestBody);
    }
}
