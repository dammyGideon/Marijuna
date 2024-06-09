namespace Herbzhub.Models.Request
{
    public record AddressRequest
    {
        public string streetAddress { get; set; }
        public int usersCity { get; set; }
        public int usersState { get; set; }
        public string userZipCode { get; set; }
    }
}
    