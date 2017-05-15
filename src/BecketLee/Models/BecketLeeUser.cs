﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BecketLee.Models
{
    public class BecketLeeUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool VerifiedUser { get; set; }
    }
}