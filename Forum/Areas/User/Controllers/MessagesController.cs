using Forum.Models;
using Forum.Servises;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    [Area("User")]
    public class MessagesController : Controller
    {
        private readonly DataManager dataManager;
        public MessagesController(DataManager manager)
        {
            this.dataManager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string commentText,string redirectUrl)
        {
            
            int? nullableDiscussonId = null;
            if (TempData["DiscussionId"] != null)
            {
                nullableDiscussonId = TempData["DiscussionId"] as int?;
            }
            int discussionId = nullableDiscussonId ?? 0;
            if (commentText != null)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Forum.Models.User user = this.dataManager.usersRepository.GetUserById(userId);
                commentText = commentText.Remove(commentText.Length - 6);
                commentText = commentText.Remove(0, 3);



                Message message = new Message();
                message.Date = DateTime.Now;
                message.Text = commentText;
                message.UserId = userId;
                message.User = user;
                message.DiscussionId = discussionId;
                message.Discussion = dataManager.discussionsRepository.GetDiscussionById(discussionId);
                dataManager.messagessRepository.SaveMessage(message);
               
            }
            return Redirect(redirectUrl);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            Message message = new Message();
            
            return PartialView("_EditMessagePartial", message);
        }

        [HttpPost]
        public IActionResult Edit(Message message,string redirectTo)
        {
            Message editedMessage = dataManager.messagessRepository.GetMessageById(message.Id);
            editedMessage.Text = message.Text;
            dataManager.messagessRepository.SaveMessage(editedMessage);
            return Redirect(redirectTo);
        }

    }
}
