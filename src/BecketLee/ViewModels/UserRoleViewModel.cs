using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BecketLee.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public IEnumerable<RoleViewModel> UserRoles { get; set; }
        public List<SelectListItem> ApplicationRoles { get; set; }

        [Required]
        public string ApplicationRoleId { get; set; }

        public string DeleteMessage { get; set; }
    }
}