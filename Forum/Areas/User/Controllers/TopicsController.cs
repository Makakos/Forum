using Forum.Models;
using Forum.Servises;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Areas.User.Controllers
{
    [Area("User")]
    public class TopicsController : Controller
    {
        private readonly DataManager dataManager;
        public TopicsController(DataManager manager)
        {
            this.dataManager = manager;
        }

        

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Add(string topicName)
        {
            Topic newTopic = new Topic();
            newTopic.Name = topicName;
            dataManager.topicsRepository.SaveTopic(newTopic);
            return Redirect("/");
        }
    }
}
