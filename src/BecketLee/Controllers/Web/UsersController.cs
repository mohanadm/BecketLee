using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BecketLee.Controllers.Web
{
    public class UsersController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private PartnerMenuViewModel _menuModel;

        public UsersController(
            IPartnerRepository menuRepository,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole>  roleManager )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _menuModel = new PartnerMenuViewModel(menuRepository);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = GetUsersViewModel( null );
            return View( model );
        }


        private UsersViewModel GetUsersViewModel( string deleteId )
        {
            var model = new UsersViewModel();
            model.Users = _userManager.Users.Select(u => new UserViewModel
            {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email

            }).OrderBy(u => u.UserName).ToList();
            if(deleteId != null )
            {
                var deleteEvent = model.Users.FirstOrDefault(e => e.Id == deleteId);
                if (deleteEvent != null)
                {
                    var delModel = new DeletionModel()
                    {
                        Controller = "Users",
                        Action = "DeleteUser",
                        UserDeleteId = deleteId,
                        Heading = "Confirm Deletion",
                        Item = "user",
                        Title = deleteEvent.UserName
                    };
                    model.UsersDeletionModel = delModel;
                }
            }
            return model;
        }

        private async Task<List<RoleViewModel>> GetUserRolesForModel( ApplicationUser user )
        {
            var roleList = new List<RoleViewModel>();
            var userRoles = await _userManager.GetRolesAsync( user );
            foreach (var userRole in userRoles)
            {
                var userRoleModel = new RoleViewModel();
                var role = _roleManager.Roles.Single( r => r.Name == userRole );
                userRoleModel.Id = role.Id;
                userRoleModel.Description = role.Description;
                userRoleModel.RoleName = userRole;
                roleList.Add( userRoleModel );
            }
            return roleList.OrderBy( r => r.RoleName ).ToList();
        }


//        [HttpGet]
//        public async Task<IActionResult> EditUserEmail( string id )
//        {
//            UserViewModel model = new UserViewModel();
//
//            if (!string.IsNullOrEmpty( id ))
//            {
//                ApplicationUser user = await _userManager.FindByIdAsync( id );
//                if (user != null)
//                {
//                    model.UserName = user.UserName;
//                    model.Email = user.Email;
//                    model.Id = user.Id;
//                }
//            }
//            return View( model );
//        }
//
//        [HttpPost]
//        [Authorize]
//        [ValidateAntiForgeryToken]
//
//        public async Task<IActionResult> EditUserEmail( UserViewModel model )
//        {
//            if (ModelState.IsValid)
//            {
//                ApplicationUser user = await _userManager.FindByIdAsync( model.Id );
//
//                if (user != null)
//                {
//                    user.Id = model.Id;
//                    user.Email = model.Email;                                      
//
//                    IdentityResult result = await _userManager.UpdateAsync( user );
//                    if(!result.Succeeded)
//                        ModelState.AddModelError("", result.Errors.FirstOrDefault().Description );
//                }
//            }
//            return View( model );
//        }


        [HttpGet]
        public IActionResult ConfirmUserDeletion( string deleteId )
        {
            var model = GetUsersViewModel( deleteId );
            return View( "Index", model );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser( string userDeleteId )
        {
            var model = GetUsersViewModel( userDeleteId );

            if (!string.IsNullOrEmpty( model.UsersDeletionModel.UserDeleteId ) )
            {
                ApplicationUser applicationUser =
                    await _userManager.FindByIdAsync( model.UsersDeletionModel.UserDeleteId );
                if (applicationUser != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync( applicationUser );
                    if (result.Succeeded)
                    {
                        return RedirectToAction( "Index", "Users" );
                    }
                }
            }

            return View( "Index", model );
        }



        [HttpGet]
        public async Task<IActionResult> UserRole(string id)
        {
            var model = await GetUserRolesViewModel(id, null);
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> UserRole( UserRolesViewModel model )
        {
            // Adds role to user
            if( ModelState.IsValid )
            {
                var user = await _userManager.FindByIdAsync( model.UserRoleViewModel.UserId );
                if ( user != null )
                {
                    if(! string.IsNullOrEmpty( model.UserRoleViewModel.ApplicationRoleId ) &&
                        model.UserRoleViewModel.ApplicationRoleId != "Please select")
                    {
                        var role = _roleManager.Roles.Single( r => r.Id == model.UserRoleViewModel.ApplicationRoleId ).Name;
                        await _userManager.AddToRoleAsync( user, role );
                    }
                }
                // reload current values
                model.UserRoleViewModel.UserRoles = await GetUserRolesForModel( user );
                model.UserRoleViewModel.ApplicationRoles = GetRolesSelectionList();
            }

            return View( model );
        }


        [HttpGet]
        public async Task<IActionResult> ConfirmUserRoleDeletion( string userId, string roleId )
        {
            var model = await GetUserRolesViewModel( userId, roleId );
            return View( "UserRole", model );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserRole( string userDeleteId, string roleDeleteId )
        {
            if( ModelState.IsValid )
            {
                if( !string.IsNullOrEmpty(userDeleteId) )
                {
                    var applicationUser = await _userManager.FindByIdAsync(userDeleteId);
                    if( applicationUser != null )
                    {
                        var role = _roleManager.Roles.Single( r => r.Id == roleDeleteId ).Name;
                        IdentityResult result = await _userManager.RemoveFromRoleAsync( applicationUser, role );
                        if( result.Succeeded )
                        {
                            return RedirectToAction( "UserRole", new { id = userDeleteId } );
                        }
                    }
                }
            }

            return RedirectToAction( "Index" );
        }



        private async Task<UserRolesViewModel> GetUserRolesViewModel(string userId, string deleteRoleId)
        {
            var model = new UserRolesViewModel();
            model.UserRoleViewModel = await GetUserRoleViewModel(userId);
            if (deleteRoleId != null)
            {
                var deleteRole = model.UserRoleViewModel.UserRoles.FirstOrDefault(r => r.Id == deleteRoleId);
                if (deleteRole != null)
                {
                    var deleteModel = new DeletionModel()
                    {
                        Controller = "Users",
                        Action = "DeleteUserRole",
                        RoleDeleteId = deleteRoleId,
                        UserDeleteId = userId,
                        Item = "user role",
                        Title = deleteRole.RoleName

                    };
                    model.UserRoleDeletionModel = deleteModel;
                }
            }

            return model;
        }

        private async Task<UserRoleViewModel> GetUserRoleViewModel(string id)
        {
            var model = new UserRoleViewModel();
            if (!string.IsNullOrEmpty(id))
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    model = new UserRoleViewModel
                    {
                        UserName = user.UserName,
                        UserId = user.Id,
                        UserRoles = await GetUserRolesForModel(user),
                        ApplicationRoles = GetRolesSelectionList()
                    };
                }
            }
            return model;
        }

        private List<SelectListItem> GetRolesSelectionList()
        {
            return _roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).OrderBy(r => r.Text).ToList();
        }


        public override PartnerMenuViewModel MenuModel
        {
            get { return _menuModel; }
            set { _menuModel = value; }
        }
    }

}