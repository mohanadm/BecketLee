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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        [HttpGet]
        public IActionResult AddUser()
        {
            UserViewModel model = new UserViewModel();
            model.ApplicationRoles = _roleManager.Roles.Select( r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            } ).ToList();

            return PartialView( "_AddUser", model );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser( UserViewModel model )
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {                    
                    UserName = model.UserName,
                    Email = model.Email
                };
                IdentityResult result = await _userManager.CreateAsync( user, model.Password );
                if (result.Succeeded)
                {
                    var applicationRole = await _roleManager.FindByIdAsync( model.ApplicationRoleId );
                    if (applicationRole != null)
                    {
                        IdentityResult roleResult = await _userManager.AddToRoleAsync( user, applicationRole.Name );
                        if (roleResult.Succeeded)
                        {
                            return RedirectToAction( "Index" );
                        }
                    }
                }
            }
            //return PartialView( "_AddUser", model );
            return View( model );
        }


        [HttpGet]
        public async Task<IActionResult> EditUser( string id )
        {
            UserViewModel model = new UserViewModel();
            model.ApplicationRoles = _roleManager.Roles.Select( r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            } ).ToList();

            if (!string.IsNullOrEmpty( id ))
            {
                ApplicationUser user = await _userManager.FindByIdAsync( id );
                if (user != null)
                {
                    model.UserName = user.UserName;
                    model.Email = user.Email;
                    model.Id = user.Id;
                    model.ApplicationRoleId = _roleManager.Roles.Single( r => r.Name == _userManager.GetRolesAsync( user ).Result.Single() ).Id;
                    var roleList = await GetUserRolesForModel( user );
                    model.UserRoles = roleList;
                }
            }
            return PartialView( "_EditUser", model );
        }

        private async Task<List<UserRoleViewModel>> GetUserRolesForModel( ApplicationUser user )
        {
            var roleList = new List<UserRoleViewModel>();

            var userRoles = await _userManager.GetRolesAsync( user );
            foreach (var userRole in userRoles)
            {
                var userRoleModel = new UserRoleViewModel();
                userRoleModel.RoleId = _roleManager.Roles.Single( r => r.Name == userRole ).Id;
                userRoleModel.RoleName = userRole;
                userRoleModel.UserId = user.Id;
                roleList.Add( userRoleModel );
            }
            return roleList;
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser( string id, UserViewModel model )
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByIdAsync( id );
                if (user != null)
                {
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    //if(model.Password == model.ConfirmPassword && !string.IsNullOrEmpty(model.Password) )
                        
                    string existingRole = _userManager.GetRolesAsync( user ).Result.Single();
                    string existingRoleId = _roleManager.Roles.Single( r => r.Name == existingRole ).Id;
                    IdentityResult result = await _userManager.UpdateAsync( user );
                    if (result.Succeeded)
                    {
                        if (existingRoleId != model.ApplicationRoleId)
                        {
                            IdentityResult roleResult = await _userManager.RemoveFromRoleAsync( user, existingRole );
                            if (roleResult.Succeeded)
                            {
                                ApplicationRole applicationRole = await _roleManager.FindByIdAsync( model.ApplicationRoleId );
                                if (applicationRole != null)
                                {
                                    IdentityResult newRoleResult = await _userManager.AddToRoleAsync( user, applicationRole.Name );
                                    if (newRoleResult.Succeeded)
                                    {
                                        return RedirectToAction( "Index" );
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
            return PartialView( "_EditUser", model );
        }

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



        [HttpGet]
        public IActionResult RegisterUser()
        {
            var user = new UserViewModel();
            user.ApplicationRoles = _roleManager.Roles.Select( r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            } ).ToList();
            user.UserRoles = new List<UserRoleViewModel>();
            
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser( UserViewModel model )
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
    }

}