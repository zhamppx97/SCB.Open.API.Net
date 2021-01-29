using SCB.Open.API.Net.LoanOrigination.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.LoanOrigination.Services
{
    public interface ILoanOriginationService
    {
        SimulatorCalResponseData GetSimulatorCal(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody);
        Task<SimulatorCalResponseData> GetSimulatorCalAsync(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody);
        InitiateApplicationsResponseData GetInitiateApplications(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody);
        Task<InitiateApplicationsResponseData> GetInitiateApplicationsAsync(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody);
        SingleApplicationsResponseData GetSingleApplications(SingleApplicationsRequestHeader singleApplicationsRequestHeader, string applicationId);
        Task<SingleApplicationsResponseData> GetSingleApplicationsAsync(SingleApplicationsRequestHeader singleApplicationsRequestHeader, string applicationId);
    }
}
