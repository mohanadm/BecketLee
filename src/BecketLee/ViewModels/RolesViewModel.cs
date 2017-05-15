using System;
using System.ComponentModel.DataAnnotations;

namespace BecketLee.ViewModels
{
    public class RolesViewModel
    {

        public string Id { get; set; }
        [Display(Name="Role Name")]
        public string RoleName { get; set; }
        public int NumberOfUsers { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}