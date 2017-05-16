using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BecketLee.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Full Name")]
        public string UserName { get; set; }
        [DataType( DataType.Password )]
        public string Password { get; set; }
        [Display( Name = "Confirm Password" )]
        [DataType( DataType.Password )]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public List<SelectListItem> ApplicationRoles { get; set; }
        [Display( Name = "Role" )]
        public string ApplicationRoleId { get; set; }
    }
}