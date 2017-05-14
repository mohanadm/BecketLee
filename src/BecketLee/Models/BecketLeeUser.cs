using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BecketLee.Models
{
    public class BecketLeeUser : IdentityUser
    {
        public DateTime CreatedDate { get; set; }
        public bool VerifiedUser { get; set; }
    }
}