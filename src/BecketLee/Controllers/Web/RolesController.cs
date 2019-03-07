using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BecketLee.Controllers.Web
{
    public class RolesController : BaseController
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private PartnerMenuViewModel _menuModel;

        public RolesController(
            IPartnerRepository menuRepository,
            RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _menuModel = new PartnerMenuViewModel(menuRepository);

        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            if (!User.IsInRole( "Administrator" ))
            {
                return RedirectToAction( "UnauthorizedView", $"Home" );
            }

            var model = GetRolesViewModel();
            return View( model );

        }

        private RolesViewModel GetRolesViewModel()
        {
            var model = new RolesViewModel
            {
                RoleViewModels = _roleManager.Roles.Select( r => new RoleViewModel
                {
                    RoleName = r.Name,
                    Id = r.Id,
                    Description = r.Description,
                    CreatedDate = r.CreatedDate
                } ).OrderBy( e => e.RoleName ).ToList()
            };
            UpdateNumberOfUsersInRoleCount(model.RoleViewModels.ToList());

            return model;
        }

        private void UpdateNumberOfUsersInRoleCount( List<RoleViewModel> model )
        {
            foreach (var user in _userManager.Users)
            {
                var userRoles = _userManager.GetRolesAsync( user ).Result;
                foreach (var userRole in userRoles)
                {
                    var role = _roleManager.Roles.Single( r => r.Name == userRole );
                    var foundRole = model.Single( r => r.RoleName == role.Name );
                    if( foundRole != null ) foundRole.NumberOfUsers++;
                }
            }
        }

        [HttpGet]
        public async Task<IActionResult> AddEditRole( string id )
        {
            var model = GetRolesViewModel();
            if ( !string.IsNullOrEmpty( id ) )
            {
                var appRole = await _roleManager.FindByIdAsync( id );
                if( appRole != null )
                {
                    model.RoleViewModel.Id = appRole.Id;
                    model.RoleViewModel.RoleName = appRole.Name;                    
                    model.RoleViewModel.Description = appRole.Description;
                }
            }

            model.OpenAddEditRoleDialog = true;
            return View( "Index", model );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditRole( string id, RoleViewModel vm )
        {
            if (ModelState.IsValid)
            {
                bool isExist = !string.IsNullOrEmpty( id );
                var applicationRole = isExist
                    ? await _roleManager.FindByIdAsync( id )
                    : new ApplicationRole()
                    {
                        CreatedDate = DateTime.UtcNow
                    };
                applicationRole.Name = vm.RoleName;
                applicationRole.Description = vm.Description;
                applicationRole.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                IdentityResult roleRuslt = isExist ? await _roleManager.UpdateAsync( applicationRole )
                                                    : await _roleManager.CreateAsync( applicationRole );
                if (roleRuslt.Succeeded)
                {
                    return RedirectToAction( "Index", GetRolesViewModel() );
                }
            }
            return View("Index", GetRolesViewModel()); 
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmDeleteRole( string id )
        {
            var model = GetRolesViewModel();
            if (!string.IsNullOrEmpty( id ))
            {
                ApplicationRole applicationRole = await _roleManager.FindByIdAsync( id );
                if (applicationRole != null)
                {
                    model.RoleDeletionModel = new DeletionModel()
                    {
                        Controller = "Roles",
                        Action = "DeleteRole",
                        Heading = "Confirm Role Deletion",
                        Item = "role",
                        RoleDeleteId = id,
                        Title = applicationRole.Name
                    };                    
                }
            }
            return View( "Index", model );
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteRole( DeletionModel model )
        {
            if (!string.IsNullOrEmpty( model.RoleDeleteId ))
            {
                var applicationRole = await _roleManager.FindByIdAsync( model.RoleDeleteId );
                if (applicationRole != null)
                {
                    IdentityResult roleRuslt = _roleManager.DeleteAsync( applicationRole ).Result;
                    if (roleRuslt.Succeeded)
                    {
                        return RedirectToAction( "Index", GetRolesViewModel() );
                    }
                }
            }
            return View( "Index", GetRolesViewModel() );
        }

        public override PartnerMenuViewModel MenuModel
        {
            get { return _menuModel; }
            set { _menuModel = value; }
        }
    }
}
