using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.Services;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BecketLee.Controllers.Web
{
    
    public class AuthController : BaseController
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailService _emailService;
        private PartnerMenuViewModel _menuModel;

        public AuthController(
            IPartnerRepository menuRepository
            , SignInManager<ApplicationUser> signInManager 
            , UserManager<ApplicationUser> userManager 
            , IEmailService emailService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _emailService = emailService;
            _menuModel = new PartnerMenuViewModel(menuRepository);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {       
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
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
        [AllowAnonymous]
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
                    return RedirectToAction("Index", "Home");
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

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register( string returnUrl = null )
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register( RegisterViewModel model, string returnUrl = null )
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
                var result = await _userManager.CreateAsync( user, model.Password );
                if (result.Succeeded)
                {
                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
                    // Send an email with this link
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Action("ConfirmEmail", "Auth", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                    await _emailService.SendEmailAsync(model.Email, "Confirm your email",
                        $"Please confirm your email by clicking this link: <a href='{callbackUrl}'>link</a>");
//                    await _signInManager.SignInAsync( user, isPersistent: false );
//                    _logger.LogInformation( 3, "User created a new account with password." );
//                    return RedirectToLocal( returnUrl );
                    return View( "RegisterConfirmation" );
                }
                AddErrors( result );
            }

            // If we got this far, something failed, redisplay form
            return View( model );
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail( string userId, string code )
        {
            if (userId == null || code == null)
            {
                return View( "Error" );
            }
            var user = await _userManager.FindByIdAsync( userId );
            if (user == null)
            {
                return View( "Error" );
            }
            var result = await _userManager.ConfirmEmailAsync( user, code );
            return View( result.Succeeded ? "ConfirmEmail" : "Error" );
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Logout()
        {
            if( User.Identity.IsAuthenticated )
                await _signInManager.SignOutAsync();

            return RedirectToAction( "Index", "Home" );
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword( ForgotPasswordViewModel model )
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync( model.Email );

                if (user == null || !(await _userManager.IsEmailConfirmedAsync( user )))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return View( "ForgotPasswordConfirmation" );
                }

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
                // Send an email with this link
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("ResetPassword", "Auth", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                await _emailService.SendEmailAsync(model.Email, "Reset Password",
                   $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");
                return View("ForgotPasswordConfirmation");
            }

            // If we got this far, something failed, redisplay form
            return View( model );
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword( string code = null )
        {
            return code == null ? View( "Error" ) : View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword( ResetPasswordViewModel model )
        {
            if (!ModelState.IsValid)
            {
                return View( model );
            }
            var user = await _userManager.FindByEmailAsync( model.Email );
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction( nameof( AuthController.ResetPasswordConfirmation ), "Auth" );
            }
            var result = await _userManager.ResetPasswordAsync( user, model.Code, model.Password );
            if (result.Succeeded)
            {
                return RedirectToAction( nameof( AuthController.ResetPasswordConfirmation ), "Auth" );
            }
            AddErrors( result );
            return View();
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        private void AddErrors( IdentityResult result )
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError( string.Empty, error.Description );
            }
        }

        public override PartnerMenuViewModel MenuModel
        {
            get { return _menuModel; }
            set { _menuModel = value; }
        }
    }
}