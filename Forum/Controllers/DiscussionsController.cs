using Forum.Models;
using Forum.Models.ViewModels;
using Forum.Servises;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    public class DiscussionsController : Controller
    {
        private readonly DataManager dataManager;
        public DiscussionsController(DataManager manager)
        {
            this.dataManager = manager;
        }
        public IActionResult Index(int id)
        {
            
            TopicViewModel topicViewModel = new TopicViewModel(dataManager, id);
            TempData["TopicId"] = id;
            return View(topicViewModel);
        }

       
        public IActionResult Discussion(int id=0)
        {
            if (id != 0)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                TempData["DiscussionId"] = id;

                TempData["Url"] = $"/Discussions/Discussion/{id}";
                Discussion discussion = dataManager.discussionsRepository.GetDiscussionById(id);
                if (dataManager.usersRepository.GetUserById(discussion.UserId) != null)
                {
                    discussion.User = dataManager.usersRepository.GetUserById(discussion.UserId);
                }
                DiscussionViewModel discussionViewModel = new DiscussionViewModel(discussion, userId);
                return View(discussionViewModel);
            }
            else
            {
                return View();
            }
        }



    }
}
