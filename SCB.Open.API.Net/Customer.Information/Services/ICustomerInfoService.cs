using SCB.Open.API.Net.Customer.Information.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Customer.Information.Services
{
    public interface ICustomerInfoService
    {
        CustomerInfoResponseData GetProfile(CustomerInfoRequestHeader customerInfoRequestHeader);
        Task<CustomerInfoResponseData> GetProfileAsync(CustomerInfoRequestHeader customerInfoRequestHeader);
    }
}
