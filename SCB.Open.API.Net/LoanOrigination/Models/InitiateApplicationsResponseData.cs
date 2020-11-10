using System;

namespace SCB.Open.API.Net.LoanOrigination.Models
{
    public class InitiateApplicationsResponseData
    {
        public InitiateApplicationsStatus status { get; set; }
        public InitiateApplicationsData data { get; set; }
        public object jsonString { get; set; }
    }

    public class InitiateApplicationsStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class InitiateApplicationsData
    {
        public string applicationId { get; set; }
        public DateTime applicationDateTime { get; set; }
    }
}
