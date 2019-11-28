using System.ComponentModel.DataAnnotations;

namespace login_registration.Models
{
    public class Register
    {
        [Required (ErrorMessage = "Enter your first name.")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters.")]
        public string firstName { get; set; }
        [Required (ErrorMessage = "Enter your last name.")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters.")]
        public string lastName { get; set; }
        [Required (ErrorMessage = "Enter your email.")]
        [EmailAddress]
        public string email { get; set; }
        [Required (ErrorMessage = "Enter your email.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required (ErrorMessage = "Enter your password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [Compare(nameof(password), ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }
    }
}