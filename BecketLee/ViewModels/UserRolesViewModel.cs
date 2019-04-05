using BecketLee.Models;

namespace BecketLee.ViewModels
{
    public class UserRolesViewModel
    {
        public UserRoleViewModel UserRoleViewModel { get; set; }
        public DeletionModel UserRoleDeletionModel { get; set; } = new DeletionModel();
    }
}