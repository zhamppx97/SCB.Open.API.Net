
namespace SCB.Open.API.Net.Customer.Information.Models
{
    public class CustomerInfoResponseData
    {
        public CustomerInfoStatus status { get; set; }
        public CustomerInfoData data { get; set; }
        public object jsonString { get; set; }
    }

    public class CustomerInfoStatus
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class CustomerInfoData
    {
        public CustomerInfoProfile profile { get; set; }
    }

    public class CustomerInfoProfile
    {
        public string citizenID { get; set; }
        public string passportNumber { get; set; }
        public string alienID { get; set; }
        public string thaiFirstName { get; set; }
        public string thaiLastName { get; set; }
        public string thaiTitle { get; set; }
        public string engFirstName { get; set; }
        public string engLastName { get; set; }
        public string engTitle { get; set; }
        public string birthDate { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string genderCode { get; set; }
        public string nationalityCode { get; set; }
        public string cardType { get; set; }
        public string countryCode { get; set; }
        public CustomerInfoAddress address { get; set; }
    }

    public class CustomerInfoAddress
    {
        public string addressSeqID { get; set; }
        public string usageCode { get; set; }
        public string ownerCode { get; set; }
        public string formatCode { get; set; }
        public string contactIndicator { get; set; }
        public string currentAddressFlag { get; set; }
        public string thaiAddressNumber { get; set; }
        public string thaiAddressVillage { get; set; }
        public string thaiAddressMoo { get; set; }
        public string thaiAddressTrok { get; set; }
        public string thaiAddressSoi { get; set; }
        public string thaiAddressThanon { get; set; }
        public string thaiAddressDistrict { get; set; }
        public string thaiAddressAmphur { get; set; }
        public string thaiAddressProvince { get; set; }
        public string thaiAddressState { get; set; }
        public string engAddressNumber { get; set; }
        public string engAddressVillage { get; set; }
        public string engAddressMoo { get; set; }
        public string engAddressTrok { get; set; }
        public string engAddressSoi { get; set; }
        public string engAddressThanon { get; set; }
        public string engAddressDistrict { get; set; }
        public string engAddressAmphur { get; set; }
        public string engAddressProvince { get; set; }
        public string engAddressState { get; set; }
        public string countryCode { get; set; }
        public string zipCode { get; set; }
        public string floorNumber { get; set; }
        public string unitNumber { get; set; }
    }
}
