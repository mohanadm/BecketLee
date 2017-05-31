using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.Kestrel.Internal.Http;

namespace BecketLee.Controllers.Web
{
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UsersController(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole>  roleManager )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new List<UserViewModel>();
            model = _userManager.Users.Select( u => new UserViewModel
            {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email
                
            } ).ToList();

            return View( model );
        }

        //[HttpGet]
        //public IActionResult AddUser()
        //{
        //    UserViewModel model = new UserViewModel();
        //    model.ApplicationRoles = _roleManager.Roles.Select( r => new SelectListItem
        //    {
        //        Text = r.Name,
        //        Value = r.Id
        //    } ).ToList();

        //    return PartialView( "_AddUser", model );
        //}

        //[HttpPost]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddUser( UserViewModel model )
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new ApplicationUser()
        //        {                    
        //            UserName = model.UserName,
        //            Email = model.Email
        //        };
        //        IdentityResult result = await _userManager.CreateAsync( user, model.Password );
        //        if (result.Succeeded)
        //        {
        //            var applicationRole = await _roleManager.FindByIdAsync( model.ApplicationRoleId );
        //            if (applicationRole != null)
        //            {
        //                IdentityResult roleResult = await _userManager.AddToRoleAsync( user, applicationRole.Name );
        //                if (roleResult.Succeeded)
        //                {
        //                    return RedirectToAction( "Index" );
        //                }
        //            }
        //        }
        //    }
        //    //return PartialView( "_AddUser", model );
        //    return View( model );
        //}


        //[HttpGet]
        //public async Task<IActionResult> EditUser( string id )
        //{
        //    UserViewModel model = new UserViewModel();
        //    model.ApplicationRoles = _roleManager.Roles.Select( r => new SelectListItem
        //    {
        //        Text = r.Name,
        //        Value = r.Id
        //    } ).ToList();

        //    if (!string.IsNullOrEmpty( id ))
        //    {
        //        ApplicationUser user = await _userManager.FindByIdAsync( id );
        //        if (user != null)
        //        {
        //            model.UserName = user.UserName;
        //            model.Email = user.Email;
        //            model.Id = user.Id;
        //            model.ApplicationRoleId = _roleManager.Roles.Single( r => r.Name == _userManager.GetRolesAsync( user ).Result.Single() ).Id;
        //            model.UserRoles = await GetUserRolesForModel( user );
        //        }
        //    }
        //    return PartialView( "_EditUser", model );
        //}


        //[HttpPost]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> EditUser( string id, UserViewModel model )
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ApplicationUser user = await _userManager.FindByIdAsync( id );
        //        if (user != null)
        //        {
        //            user.UserName = model.UserName;
        //            user.Email = model.Email;
        //            //if(model.Password == model.ConfirmPassword && !string.IsNullOrEmpty(model.Password) )
                        
        //            string existingRole = _userManager.GetRolesAsync( user ).Result.Single();
        //            string existingRoleId = _roleManager.Roles.Single( r => r.Name == existingRole ).Id;
        //            IdentityResult result = await _userManager.UpdateAsync( user );
        //            if (result.Succeeded)
        //            {
        //                if (existingRoleId != model.ApplicationRoleId)
        //                {
        //                    IdentityResult roleResult = await _userManager.RemoveFromRoleAsync( user, existingRole );
        //                    if (roleResult.Succeeded)
        //                    {
        //                        ApplicationRole applicationRole = await _roleManager.FindByIdAsync( model.ApplicationRoleId );
        //                        if (applicationRole != null)
        //                        {
        //                            IdentityResult newRoleResult = await _userManager.AddToRoleAsync( user, applicationRole.Name );
        //                            if (newRoleResult.Succeeded)
        //                            {
        //                                return RedirectToAction( "Index" );
        //                            }
        //                        }
        //                    }
        //                }
                        
        //            }
        //        }
        //    }
        //    return PartialView( "_EditUser", model );
        //}

        [HttpGet]
        public async Task<IActionResult> DeleteUser( string id )
        {
            string name = string.Empty;
            if (!string.IsNullOrEmpty( id ))
            {
                ApplicationUser applicationUser = await _userManager.FindByIdAsync( id );
                if (applicationUser != null)
                {
                    name = applicationUser.UserName;
                }
            }
            return PartialView( "_DeleteUser", name );
            
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser( string id, IFormCollection form )
        {
            if (!String.IsNullOrEmpty( id ))
            {
                ApplicationUser applicationUser = await _userManager.FindByIdAsync( id );
                if (applicationUser != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync( applicationUser );
                    if (result.Succeeded)
                    {
                        return RedirectToAction( "Index" );
                    }
                }
            }
            //return PartialView( "_DeleteUser", id );
            return View();
        }



        //[HttpGet]
        //public IActionResult AddEditUser()
        //{
        //    var user = new UserViewModel();
        //    user.ApplicationRoles = _roleManager.Roles.Select( r => new SelectListItem
        //    {
        //        Text = r.Name,
        //        Value = r.Id
        //    } ).ToList();
        //    user.UserRoles = new List<UserRoleViewModel>();
            
        //    return View(user);
        //}

        [HttpGet]
        public async Task<IActionResult> AddEditUser( string id)
        {
            UserViewModel model = new UserViewModel();
            model.ApplicationRoles = _roleManager.Roles.Select( r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            } ).ToList();

            model.UserRoles = new List<RoleViewModel>();

            if ( !string.IsNullOrEmpty( id ) )
            {
                ApplicationUser user = await _userManager.FindByIdAsync( id );
                if( user != null )
                {
                    model.UserName = user.UserName;
                    model.Email = user.Email;
                    model.Id = user.Id;
                    model.UserRoles = await GetUserRolesForModel( user );                    
                }
            }
            return View( model );
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
            return roleList;
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditUser( UserViewModel model )
        {
            if( ModelState.IsValid )
            {
                var user = new ApplicationUser()
                {
                    UserName = model.UserName,
                    Email = model.Email
                };
                IdentityResult result = await _userManager.CreateAsync( user, model.Password );
                if( !result.Succeeded ) 
                    ModelState.AddModelError("", result.Errors.FirstOrDefault().Description);
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> UserRole( string id )
        {
            var model = await GetUserRoleViewModel( id );
            return View( model );
        }

        private async Task<UserRoleViewModel> GetUserRoleViewModel( string id )
        {
            var model = new UserRoleViewModel();
            if( !string.IsNullOrEmpty( id ) )
            {
                var user = await _userManager.FindByIdAsync( id );
                if( user != null )
                {
                    model = new UserRoleViewModel
                    {
                        UserName = user.UserName,
                        UserId = user.Id,
                        UserRoles = await GetUserRolesForModel( user ),
                        ApplicationRoles = GetRolesSelectionList()
                    };
                }
            }
            return model;
        }

        private List<SelectListItem> GetRolesSelectionList()
        {
            return _roleManager.Roles.Select( r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            } ).ToList();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRole( UserRoleViewModel model )
        {
            if( ModelState.IsValid )
            {
                var user = await _userManager.FindByIdAsync( model.UserId );
                if ( user != null )
                {
                    if(! string.IsNullOrEmpty( model.ApplicationRoleId ) &&
                        model.ApplicationRoleId != "Please select")
                    {
                        var role = _roleManager.Roles.Single( r => r.Id == model.ApplicationRoleId ).Name;
                        await _userManager.AddToRoleAsync( user, role );
                    }
                }
                // reload current values
                model.UserRoles = await GetUserRolesForModel( user );

            }

            return View( model );
        }

        [HttpGet]
        public async Task<IActionResult> DeleteUserRole( string userid, string roleid )
        {
            
            var model = new UserRoleViewModel();
            if (!string.IsNullOrEmpty( userid ) && !string.IsNullOrEmpty( roleid ))
            {
                model = await GetUserRoleViewModel( userid );
                model.ApplicationRoles = GetRolesSelectionList();
                model.ApplicationRoleId = roleid;
                var applicationUser = await _userManager.FindByIdAsync( userid );
                if( applicationUser != null )
                {
                    var roleName = _roleManager.Roles.Single( r => r.Id == roleid ).Name;
                    model.DeleteMessage = roleName + " for " + applicationUser.UserName;
                }
                model.UserRoles = await GetUserRolesForModel( applicationUser );
            }
            return PartialView( "_DeleteUserRole", model );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserRole( string userid, string applicationroleid, IFormCollection form )
        {
            if( ModelState.IsValid )
            {
                if( !string.IsNullOrEmpty( userid ) )
                {
                    var applicationUser = await _userManager.FindByIdAsync( userid );
                    if( applicationUser != null )
                    {
                        var role = _roleManager.Roles.Single( r => r.Id == applicationroleid ).Name;
                        IdentityResult result = await _userManager.RemoveFromRoleAsync( applicationUser, role );
                        if( result.Succeeded )
                        {
                            return RedirectToAction( "UserRole", new { id = userid } );
                        }
                    }
                }
            }

            return RedirectToAction( "Index" );
        }
    }

}