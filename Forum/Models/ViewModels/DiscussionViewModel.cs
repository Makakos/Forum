using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models.ViewModels
{
    public class DiscussionViewModel
    {
        public Discussion Discussion { get; set; }
        public string UserId { get; set; }
        public DiscussionViewModel(Discussion discussion,string id)
        {
            Discussion = discussion;
            UserId = id;
        }
    }
}
