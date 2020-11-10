using Newtonsoft.Json;
using RestSharp;
using SCB.Open.API.Net.Infrastructure;
using SCB.Open.API.Net.LoanOrigination.Models;
using SCB.Open.API.Net.Settings;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.LoanOrigination.Services
{
    public class LoanOriginationService : ILoanOriginationService
    {
        private readonly AppSettings _appSettings = new AppSettings();
        private readonly string _remoteServiceBaseUrl;

        public LoanOriginationService()
        {
            _remoteServiceBaseUrl = $"{_appSettings.BaseApiUrl}";
        }

        public SimulatorCalResponseData GetSimulatorCal(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody)
        {
            var client = new RestClient(OpenAPI.LoanOrigination.SimulatorCalculate(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", simulatorCalRequestHeader.AcceptLanguage);
            request.AddHeader("resourceOwnerId", simulatorCalRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", simulatorCalRequestHeader.RequestUId);
            request.AddHeader("authorization", simulatorCalRequestHeader.Authorization);
            request.AddHeader("accept-language", simulatorCalRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(simulatorCalRequestBody));

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<SimulatorCalResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<SimulatorCalResponseData> GetSimulatorCalAsync(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody)
        {
            var client = new RestClient(OpenAPI.LoanOrigination.SimulatorCalculate(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", simulatorCalRequestHeader.AcceptLanguage);
            request.AddHeader("resourceOwnerId", simulatorCalRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", simulatorCalRequestHeader.RequestUId);
            request.AddHeader("authorization", simulatorCalRequestHeader.Authorization);
            request.AddHeader("accept-language", simulatorCalRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(simulatorCalRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<SimulatorCalResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public InitiateApplicationsResponseData GetInitiateApplications(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody)
        {
            var client = new RestClient(OpenAPI.LoanOrigination.InitiateApplications(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", initiateApplicationsRequestHeader.AcceptLanguage);
            request.AddHeader("resourceOwnerId", initiateApplicationsRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", initiateApplicationsRequestHeader.RequestUId);
            request.AddHeader("authorization", initiateApplicationsRequestHeader.Authorization);
            request.AddHeader("accept-language", initiateApplicationsRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(initiateApplicationsRequestBody));

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<InitiateApplicationsResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<InitiateApplicationsResponseData> GetInitiateApplicationsAsync(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody)
        {
            var client = new RestClient(OpenAPI.LoanOrigination.InitiateApplications(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", initiateApplicationsRequestHeader.AcceptLanguage);
            request.AddHeader("resourceOwnerId", initiateApplicationsRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", initiateApplicationsRequestHeader.RequestUId);
            request.AddHeader("authorization", initiateApplicationsRequestHeader.Authorization);
            request.AddHeader("accept-language", initiateApplicationsRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(initiateApplicationsRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<InitiateApplicationsResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }
    }
}
