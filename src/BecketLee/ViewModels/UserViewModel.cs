using System;
using System.ComponentModel.DataAnnotations;

namespace BecketLee.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool VerifiedUser { get; set; }
    }
}