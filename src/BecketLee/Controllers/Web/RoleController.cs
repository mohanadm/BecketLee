using System.Collections.Generic;
using System.Linq;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BecketLee.Controllers.Web
{
    public class RoleController : Controller
    {
        private readonly RoleManager<BecketLeeRole> _roleManager;

        public RoleController(RoleManager<BecketLeeRole> roleManager )
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Roles()
        {
            if (!User.IsInRole( "Administrator" ))
            {
                RedirectToAction( "UnauthorizedView", "App" );
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
    }
}
