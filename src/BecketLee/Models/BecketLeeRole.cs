using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BecketLee.Models
{
    public class BecketLeeRole : IdentityRole
    {
        
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string IPAddress { get; set; }

    }
}