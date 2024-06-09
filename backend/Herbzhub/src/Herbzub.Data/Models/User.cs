using System.ComponentModel.DataAnnotations;

namespace Herbzhub.Data.Models
{
    public class User : BaseEntity
    {
        
        [Required(ErrorMessage = "Email Field is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } 

        [Required(ErrorMessage = "Password Field is required")]
        [MinLength(6, ErrorMessage = "Maximum length should be greater than 6")]
        public string HashPassword { get; set; }
        

        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenExpiry { get; set; }


        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        public SMSVerificationCode SMSVerificationCodes {  get; set; }
        public PersonalIdentification personalIdentifications {  get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}

