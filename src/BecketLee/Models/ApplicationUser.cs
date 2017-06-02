using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BecketLee.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;        
    }
}