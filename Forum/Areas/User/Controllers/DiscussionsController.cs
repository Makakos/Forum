using Forum.Models;
using Forum.Servises;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Forum.Areas.User.Controllers
{
    [Area("User")]
    public class DiscussionsController : Controller
    {
        private readonly DataManager dataManager;
        public DiscussionsController(DataManager manager)
        {
            this.dataManager = manager;
        }

        [HttpGet]
        public IActionResult Create(int id)
        {


            return View();
        }


        [HttpPost]
        public IActionResult Create(Discussion discussion,string returnUrl)
        {

            int? nullableTopicId = null;
            if (TempData["TopicId"] != null)
            {
                nullableTopicId = TempData["TopicId"] as int?;
            }
            int topicId = nullableTopicId ?? 0;
            if (this.ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Forum.Models.User user = this.dataManager.usersRepository.GetUserById(userId);


                discussion.Id = 0;
                discussion.Date = DateTime.Now;
                discussion.UserId = userId;
                discussion.User = user;
                discussion.TopicId = topicId;
                discussion.Topic = dataManager.topicsRepository.GetTopicById(topicId);
                dataManager.discussionsRepository.SaveDiscussion(discussion);
                
            
            }
            if (returnUrl != null)
            {
                return Redirect(returnUrl);
            }
            else
            {
                return Redirect($"/Discussions/Index/{topicId}");
            }
         
        }

      
      
            
        
    }
}
