namespace Herbzhub.Models.Request
{
    public record ResentPasswordRequest
    { 
        public string Token {  get; set; }
        public string Password { get; set; }
        public string ComfirmPassword {  get; set; }
    }
}
    