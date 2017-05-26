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
        [DataType( DataType.Password )]
        [MinLength(8)]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [Display( Name = "Confirm Password" )]
        [DataType( DataType.Password )]        
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(512)]
        public string Email { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public List<SelectListItem> ApplicationRoles { get; set; }

        public string ApplicationRoleId { get; set; }

        [Display( Name = "Roles" )]
        public IEnumerable<UserRoleViewModel> UserRoles { get; set; }
    }
}