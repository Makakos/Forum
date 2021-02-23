using Forum.Models;
using Forum.Models.ViewModels;
using Forum.Servises;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Security.Claims;

namespace Cinema.Areas.UserArea.Controllers
{
    [Area("User")]
    public class AccountController : Controller
    {
      
        private readonly SignInManager<User> signInManager;
        private readonly DataManager manager;

        public AccountController(DataManager dataManager, SignInManager<User> signIn)
        {
            this.signInManager = signIn;
            this.manager = dataManager;
        }

        

        [HttpGet]
        public IActionResult Profile()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            User user = this.manager.usersRepository.GetUserById(userId);

            
            return this.View(user);
        }

        [HttpPost]
        public IActionResult Profile(UserViewModel userViewModel)
        {

           

            if (this.ModelState.IsValid)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                User user = this.manager.usersRepository.GetUserById(userId);

                if (userViewModel.Avatar != null && (userViewModel.Avatar.ContentType!= "image/png" &&
                    userViewModel.Avatar.ContentType != "image/jpeg" &&
                    userViewModel.Avatar.ContentType != "image/gif"))
                {
                    ModelState.AddModelError("Avatar", "You can choose only images");
                    return View(user);
                }

                if (userViewModel.Avatar != null)
                {
                    byte[] imageData = null;
                    // считываем переданный файл в массив байтов
                    using (var binaryReader = new BinaryReader(userViewModel.Avatar.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)userViewModel.Avatar.Length);
                    }
                  
                    user.Avatar = imageData;
                }
                //при изменении почты и телефона они становятся не подтвержденными
                if(user.Email!=userViewModel.Email)
                {
                    user.EmailConfirmed = false;
                }
                if (user.PhoneNumber!=null && user.PhoneNumber != userViewModel.PhoneNumber)
                {
                    user.PhoneNumberConfirmed = false;
                }

                user.UserName = userViewModel.UserName;
                user.NormalizedUserName = userViewModel.UserName.ToUpper();
                user.PhoneNumber = userViewModel.PhoneNumber;
                user.Email = userViewModel.Email;
                user.NormalizedEmail = userViewModel.Email.ToUpper();
                this.manager.usersRepository.SaveUser(user);
                
                return this.RedirectToAction("Profile", "Account", "/User");
            }

            return this.View();
        }

        [Authorize]
        public IActionResult Logout()
        {
            this.signInManager.SignOutAsync();
            
            return Redirect(@"\Home\Index");
        }
    }
}
