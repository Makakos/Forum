using Forum.Models;
using Forum.Models.ViewModels;
using Forum.Servises;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager manager)
        {
            this.dataManager = manager;
        }

        public IActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = this.dataManager.usersRepository.GetUserById(userId)??null;
                this.ViewBag.UserName = user.UserName??"";
            }

            List<Topic> topics= dataManager.topicsRepository.GetTopics().Include(x => x.Discussions).ToList(); 
            
            return View(topics);
            
        }

      

    }
}


    
