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

namespace BecketLee.Controllers.Web
{
    public class RolesController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RolesController(RoleManager<ApplicationRole> roleManager )
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            if (!User.IsInRole( "Administrator" ))
            {
                return RedirectToAction( "UnauthorizedView", "App" );
            }
            var model = new List<RolesViewModel>();            
            model = _roleManager.Roles.Select( r => new RolesViewModel
            {
                RoleName = r.Name
                , Id = r.Id
                , Description = r.Description
                , NumberOfUsers = r.Users.Count
                , CreatedDate = r.CreatedDate
            } ).ToList();

            return View( model );

        }

        [HttpGet]
        public async Task<IActionResult> AddEditRole( string id )
        {
            var model = new RoleViewModel();
            if( !string.IsNullOrEmpty( id ) )
            {
                var appRole = await _roleManager.FindByIdAsync( id );
                if( appRole != null )
                {
                    model.Id = appRole.Id;
                    model.RoleName = appRole.Name;
                    model.Description = appRole.Description;
                }
            }
            return PartialView( "_AddEditRole", model );
        }

        [HttpPost]
        public async Task<IActionResult> AddEditRole( string id, RolesViewModel vm )
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
                    return RedirectToAction( "Index" );
                }
            }
            return View( vm );
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRole( string id )
        {
            string name = string.Empty;
            if (!string.IsNullOrEmpty( id ))
            {
                ApplicationRole applicationRole = await _roleManager.FindByIdAsync( id );
                if (applicationRole != null)
                {
                    name = applicationRole.Name;
                }
            }
            return PartialView( "_DeleteRole", name );
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole( string id, IFormCollection form )
        {
            if (!string.IsNullOrEmpty( id ))
            {
                var applicationRole = await _roleManager.FindByIdAsync( id );
                if (applicationRole != null)
                {
                    IdentityResult roleRuslt = _roleManager.DeleteAsync( applicationRole ).Result;
                    if (roleRuslt.Succeeded)
                    {
                        return RedirectToAction( "Index" );
                    }
                }
            }
            return View();
        }
    }
}
