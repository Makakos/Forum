using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Text { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Author")]
        public string UserId { get; set; }
        public User User { get; set; }

        [Display(Name = "Topic")]
        public int DiscussionId { get; set; }
        public Discussion Discussion { get; set; }
    }
}
