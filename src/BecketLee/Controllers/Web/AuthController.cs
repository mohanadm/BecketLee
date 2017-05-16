using System.Threading.Tasks;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BecketLee.Controllers.Web
{
    public class AuthController : Controller
    {
        private readonly SignInManager<BecketLeeUser> _signInManager;

        public AuthController(SignInManager<BecketLeeUser> signInManager )
        {
            _signInManager = signInManager;
        }

        public IActionResult Index(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (returnUrl != null)
                    Redirect( returnUrl );
            }        
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Auth" );

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
        



    }
}