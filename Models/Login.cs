using System.ComponentModel.DataAnnotations;

namespace login_registration.Models
{
    public class Login
    {
        [Required (ErrorMessage = "Enter your email.")]
        [EmailAddress]
        public string loginEmail { get; set; }
        [Required (ErrorMessage = "Enter your password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string loginPassword { get; set; }
    }
}