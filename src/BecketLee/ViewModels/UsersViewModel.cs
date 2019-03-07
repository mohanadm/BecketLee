using System.Collections.Generic;
using BecketLee.Models;

namespace BecketLee.ViewModels
{
    public class UsersViewModel
    {
        public IEnumerable<UserViewModel> Users { get; set; }

        public DeletionModel UsersDeletionModel { get; set; } = new DeletionModel();
    }
}