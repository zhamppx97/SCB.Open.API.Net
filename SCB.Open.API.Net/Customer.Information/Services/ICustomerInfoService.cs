using SCB.Open.API.Net.Customer.Information.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Customer.Information.Services
{
    public interface ICustomerInfoService
    {
        public CustomerInfoResponseData GetProfile(CustomerInfoRequestHeader customerInfoRequestHeader);

        public Task<CustomerInfoResponseData> GetProfileAsync(CustomerInfoRequestHeader customerInfoRequestHeader);
    }
}
