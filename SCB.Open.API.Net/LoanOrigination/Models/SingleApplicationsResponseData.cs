using System;

namespace SCB.Open.API.Net.LoanOrigination.Models
{
    public class SingleApplicationsResponseData
    {
        public SingleApplicationsStatus status { get; set; }
        public SingleApplicationsData data { get; set; }
        public object jsonString { get; set; }
    }

    public class SingleApplicationsStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class SingleApplicationsData
    {
        public string userId { get; set; }
        public string applicationId { get; set; }
        public string loanApplicationStatus { get; set; }
        public DateTime createdDateTime { get; set; }
        public bool ncbConsentFlag { get; set; }
        public bool crossSellConsentFlag { get; set; }
        public bool modelConsentFlag { get; set; }
        public bool tncFlag { get; set; }
        public SingleApplicationsCustomer customer { get; set; }
        public SingleApplicationsLoan loan { get; set; }
        public string expiryDatetime { get; set; }
        public string submitCounter { get; set; }
    }

    public class SingleApplicationsCustomer
    {
        public string dateOfBirth { get; set; }
        public string title { get; set; }
        public string firstNameThai { get; set; }
        public string lastNameThai { get; set; }
        public string nationality { get; set; }
        public string typeOfCustomerProfile { get; set; }
        public string idCardExpiryDate { get; set; }
        public string idCardLaserCode { get; set; }
        public SingleApplicationsBusinessinfo businessInfo { get; set; }
        public SingleApplicationsPersonalinfo personalInfo { get; set; }
        public SingleApplicationsContactinfo contactInfo { get; set; }
        public SingleApplicationsEmploymentinfo employmentInfo { get; set; }
        public SingleApplicationsReferencedocument referenceDocument { get; set; }
    }

    public class SingleApplicationsBusinessinfo
    {
        public int monthsOfBusinessExp { get; set; }
        public int yearsOfBusinessExp { get; set; }
    }

    public class SingleApplicationsPersonalinfo
    {
        public string gender { get; set; }
        public string hasChildren { get; set; }
    }

    public class SingleApplicationsContactinfo
    {
        public SingleApplicationsCurrentaddress currentAddress { get; set; }
        public string mobileNo { get; set; }
    }

    public class SingleApplicationsCurrentaddress
    {
        public string formatCode { get; set; }
        public string addressNo { get; set; }
        public string moo { get; set; }
        public string road { get; set; }
        public string amphur { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string zipCode { get; set; }
    }

    public class SingleApplicationsEmploymentinfo
    {
        public string employerName { get; set; }
        public string position { get; set; }
        public string professional { get; set; }
        public string sourceOfIncome { get; set; }
        public SingleApplicationsOfficeaddress officeAddress { get; set; }
    }

    public class SingleApplicationsOfficeaddress
    {
        public string formatCode { get; set; }
        public string addressNo { get; set; }
        public string moo { get; set; }
        public string road { get; set; }
        public string amphur { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string zipCode { get; set; }
    }

    public class SingleApplicationsReferencedocument
    {
        public string type { get; set; }
        public string country { get; set; }
        public string referenceNo { get; set; }
    }

    public class SingleApplicationsLoan
    {
        public string productIntent { get; set; }
        public string sourceCode { get; set; }
        public string loanRequestDetail { get; set; }
        public SingleApplicationsProducttype productType { get; set; }
        public SingleApplicationsRequestedproduct requestedProduct { get; set; }
    }

    public class SingleApplicationsProducttype
    {
        public string productType { get; set; }
        public string subType { get; set; }
        public string optionType { get; set; }
    }

    public class SingleApplicationsRequestedproduct
    {
        public string repaymentMethod { get; set; }
    }
}
