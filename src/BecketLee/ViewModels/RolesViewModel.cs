using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BecketLee.Models;

namespace BecketLee.ViewModels
{
    public class RolesViewModel
    {
        public IEnumerable<RoleViewModel> RoleViewModels { get; set; }

        /// <summary>
        /// The currently selected model from the enumeration
        /// </summary>
        public RoleViewModel RoleViewModel { get; set; } = new RoleViewModel();

        public bool OpenAddEditRoleDialog { get; set; }

        /// <summary>
        /// The currently selected role for deletion
        /// </summary>
        public DeletionModel RoleDeletionModel { get; set; } = new DeletionModel();

    }
}