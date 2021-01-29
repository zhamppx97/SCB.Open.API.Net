using SCB.Open.API.Net.Payments.EWallets.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.EWallets.Services
{
    public interface IEWalletsService
    {
        QRCodeCreateResponseData GetQRCodeCreate(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody);
        Task<QRCodeCreateResponseData> GetQRCodeCreateAsync(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody);
        InquireResponseData GetInquire(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody);
        Task<InquireResponseData> GetInquireAsync(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody);
        CancelResponseData GetCancel(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody);
        Task<CancelResponseData> GetCancelAsync(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody);
        RefundResponseData GetRefund(RefundRequestHeader refundRequestHeader, RefundRequestBody refundRequestBody);
        Task<RefundResponseData> GetRefundAsync(RefundRequestHeader refundRequestHeader, RefundRequestBody refundRequestBody);
        QRCodeCancelResponseData GetQRCodeCancel(QRCodeCancelRequestHeader qRCodeCancelRequestHeader, QRCodeCancelRequestBody qRCodeCancelRequestBody);
        Task<QRCodeCancelResponseData> GetQRCodeCancelAsync(QRCodeCancelRequestHeader qRCodeCancelRequestHeader, QRCodeCancelRequestBody qRCodeCancelRequestBody);
        PayResponseData GetPay(PayRequestHeader payRequestHeader, PayRequestBody payRequestBody);
        Task<PayResponseData> GetPayAsync(PayRequestHeader payRequestHeader, PayRequestBody payRequestBody);
    }
}
