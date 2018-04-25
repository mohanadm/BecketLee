using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BecketLee.Models
{
    public class ApplicationRole : IdentityRole
    {
        
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string IPAddress { get; set; }

    }
}