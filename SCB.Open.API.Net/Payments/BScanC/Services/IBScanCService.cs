using SCB.Open.API.Net.Payments.BScanC.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.BScanC.Services
{
    public interface IBScanCService
    {
        MerchantRtpConfirmResponseData GetMerchantRtpConfirm(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody);
        Task<MerchantRtpConfirmResponseData> GetMerchantRtpConfirmAsync(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody);
        MerchantRtpRefundResponseData GetMerchantRtpRefund(MerchantRtpRefundRequestHeader merchantRtpRefundRequestHeader, MerchantRtpRefundRequestBody merchantRtpRefundRequestBody);
        Task<MerchantRtpRefundResponseData> GetMerchantRtpRefundAsync(MerchantRtpRefundRequestHeader merchantRtpRefundRequestHeader, MerchantRtpRefundRequestBody merchantRtpRefundRequestBody);
    }
}
