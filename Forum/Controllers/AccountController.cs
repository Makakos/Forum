using Forum.Models;
using Forum.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Forum.Servises;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Drawing;
using System.Linq;

namespace Forum.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly DataManager dataManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,DataManager dataManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Registration(string returnUrl)
        {
            this.ViewBag.ReturnURL = returnUrl;
            return this.View(new RegistrationViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel model,string returnUrl)
        {
            if (this.ModelState.IsValid)
            {
              
                if (!dataManager.usersRepository.GetUsers().Any(x => x.Email == model.Email))
                {
                    User user = new User { UserName = model.Name, Years = model.Year, Email = model.Email, PhoneNumber = model.PhoneNumber };
                    var result = await this.userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {

                        var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        var callbackUrl = Url.Action(
                            "ConfirmEmail",
                            "Account",
                            new { userId = user.Id, code = code },
                            protocol: HttpContext.Request.Scheme);
                        EmailService emailService = new EmailService();

                        await emailService.SendEmailAsync(model.Email, "Confirm your account",
                            $"Confirm registration by clicking on the link: <a href='{callbackUrl}'>link</a>");

                      

                        await this.userManager.AddToRoleAsync(user, "User");

                        
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            var errors = result.Errors;
                            var message = string.Join(", ", result.Errors.Select(x => "Code " + x.Code + " Description" + x.Description));
                            this.ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }

            return this.View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            else
                return View("Error");
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            this.ViewBag.ReturnURL = returnUrl;
           
            return this.View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (this.ModelState.IsValid)
            {
                
                   

                var user = await this.userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    // проверяем, подтвержден ли email
                    if (!await userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError(string.Empty, "You didn`t confirmed you mail");
                        return View(model);
                    }
                    await this.signInManager.SignOutAsync();
                    var result = await this.signInManager.PasswordSignInAsync(user.UserName, model.Password, true, false);
                    if (result.Succeeded)
                    {
                        
                        return this.Redirect(returnUrl ?? "/");
                    }
                }

              
                this.ModelState.AddModelError(nameof(LoginViewModel), "Wrong login or password");
            }

            return this.View(model);
        }

        [Authorize]
        public IActionResult Logout()
        {
            this.signInManager.SignOutAsync();
           
            return this.RedirectToAction("Index", "Home");
        }
    }
}
