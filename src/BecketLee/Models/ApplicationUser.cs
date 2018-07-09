using System;
using Microsoft.AspNetCore.Identity;

namespace BecketLee.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;        
    }
}