using SCB.Open.API.Net.Payments.BScanC.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.BScanC.Services
{
    public interface IBScanCService
    {
        public MerchantRtpConfirmResponseData GetMerchantRtpConfirm(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody);
        public Task<MerchantRtpConfirmResponseData> GetMerchantRtpConfirmAsync(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody);
    }
}
