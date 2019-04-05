using System.ComponentModel.DataAnnotations;

namespace BecketLee.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}