using System.Linq;
using System.Threading.Tasks;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BecketLee.Controllers.Web
{
    public class AuthController : Controller
    {
        private readonly SignInManager<BecketLeeUser> _signInManager;
        //private readonly RoleManager<BecketLeeUser> _roleManager;
        private readonly IHostingEnvironment _environment;

        public AuthController(
            IHostingEnvironment environment
            , SignInManager<BecketLeeUser> signInManager 
            //, RoleManager<BecketLeeUser> roleManager 
            )
        {
            _signInManager = signInManager;
            //_roleManager = roleManager;
            _environment = environment;
        }

        public IActionResult Login(string returnUrl)
        {

            if( User.Identity.IsAuthenticated )
            {
                if (returnUrl != null)
                    Redirect( returnUrl );
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login( LoginViewModel vm, string returnUrl )
        {
            if (ModelState.IsValid)
            {                
                var signInResult = await _signInManager.PasswordSignInAsync( vm.Username, vm.Password, vm.PersistLogin, false );
                if( signInResult.Succeeded )
                {                    
                    if( returnUrl != null)
                        return Redirect( returnUrl );
                }
                if (signInResult.IsLockedOut)
                {
                    // Todo Create locked out redirect
                }
                else
                {
                    ModelState.AddModelError("", "Username and password combination is incorrect.");
                }
            }
            return View();
        }

        public async Task<ActionResult> Logout()
        {
            if( User.Identity.IsAuthenticated )
                await _signInManager.SignOutAsync();

            return RedirectToAction( "Index", "App" );
        }

//        public IActionResult Roles()
//        {
//            if( !User.IsInRole( "Administrator" ) )
//            {
//                RedirectToAction( "Index", "App" );
//            }
//
//            var roles = _roleManager.Roles.ToList();
//            return View( roles );
//
//        }


    }
}