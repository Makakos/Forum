using Forum.Models;
using Forum.Servises;
using Microsoft.AspNetCore.Authorization;
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
        public IActionResult Create(string commentText, string RedirectUrl)
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
                



                Message message = new Message();
                message.Date = DateTime.Now;
                message.Text = commentText;
                message.UserId = userId;
                message.User = user;
                message.DiscussionId = discussionId;
                message.Discussion = dataManager.discussionsRepository.GetDiscussionById(discussionId);
                dataManager.messagessRepository.SaveMessage(message);

            }
            return Redirect(RedirectUrl);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            Message message = new Message();

            return PartialView("_EditMessagePartial", message);
        }

        [HttpPost]
        public IActionResult Edit(Message message, string redirectTo)
        {
            Message editedMessage = dataManager.messagessRepository.GetMessageById(message.Id);
            editedMessage.Text = message.Text;
            if(redirectTo==null)
            {
                redirectTo = $"/Discussions/Discussion/{editedMessage.DiscussionId}";
            }
            dataManager.messagessRepository.SaveMessage(editedMessage);
            return Redirect(redirectTo);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(string Id,string RedirectUrl)
        {
            int messageId = Convert.ToInt32(Id);
        
            dataManager.messagessRepository.DeleteMessageById(messageId);
            return Redirect(RedirectUrl);
        }
    }
}
