namespace Herbzhub.Models.Request
{
    public record BusinessDetails
    {
        
        public string BusinessName { get; set; }
        public string BusinessEIN { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessContact { get; set; }
        public string BusinessAddress { get; set; }
        public int BusinessCity { get; set; }

        public int BusinessState{get;set;}

        public string BusinessZipCode { get; set; }
    }
}
    