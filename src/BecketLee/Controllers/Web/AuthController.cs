using System.Threading.Tasks;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BecketLee.Controllers.Web
{
    public class AuthController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthController(SignInManager<ApplicationUser> signInManager )
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {       
            return View();
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
        [ValidateAntiForgeryToken]
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

        [Authorize]
        public async Task<ActionResult> Logout()
        {
            if( User.Identity.IsAuthenticated )
                await _signInManager.SignOutAsync();

            return RedirectToAction( "Index", "App" );
        }
        



    }
}