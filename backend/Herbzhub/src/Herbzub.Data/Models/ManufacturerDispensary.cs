namespace Herbzhub.Data.Models
{
    public class ManufacturerDispensary : BaseEntity
    {
        public int PersonalIdentificationId { get; set; }
        public PersonalIdentification PersonalIdentification { get; set; }
        public string SerialNumber { get; set; }
        public string StateLicenseNumber { get; set; }
        public string LegalBusinessName { get; set; }
        public string BusinessEIN { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessContact { get; set; }
        public string BusinessAddress { get; set; }
        public int BusinessCityId { get; set; }
        public City BusinessCity { get; set; }
        public int BusinessStateId { get; set; }
        public State BusinessState { get; set; }
        public string BusinessZipCode { get; set; }
    }

    


}
