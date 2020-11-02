using SCB.Open.API.Net.Payments.EWallets.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.EWallets.Services
{
    public interface IEWalletsService
    {
        public QRCodeCreateResponseData GetQRCodeCreate(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody);
        public Task<QRCodeCreateResponseData> GetQRCodeCreateAsync(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody);
    }
}
