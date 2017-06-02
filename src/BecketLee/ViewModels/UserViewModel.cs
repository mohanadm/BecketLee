using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BecketLee.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display( Name = "User Name" )]
        [StringLength( 255 )]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display( Name = "Email" )]
        [StringLength( 512 )]
        public string Email { get; set; }

        [Required]
        [DataType( DataType.Password )]
        [Display( Name = "Password" )]
        [StringLength( 100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8 )]
        public string Password { get; set; }

        [DataType( DataType.Password )]
        [Display( Name = "Confirm password" )]
        [Compare( "Password", ErrorMessage = "The password and confirmation password do not match." )]
        public string ConfirmPassword { get; set; }

        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public List<SelectListItem> ApplicationRoles { get; set; }

        public string ApplicationRoleId { get; set; }

        [Display( Name = "Roles" )]
        public IEnumerable<RoleViewModel> UserRoles { get; set; }
    }
}