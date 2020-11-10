using SCB.Open.API.Net.LoanOrigination.Models;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.LoanOrigination.Services
{
    public interface ILoanOriginationService
    {
        public SimulatorCalResponseData GetSimulatorCal(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody);
        public Task<SimulatorCalResponseData> GetSimulatorCalAsync(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody);
        public InitiateApplicationsResponseData GetInitiateApplications(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody);
        public Task<InitiateApplicationsResponseData> GetInitiateApplicationsAsync(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody);
    }
}
