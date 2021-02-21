using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Discussion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Author")]
        public string UserId { get; set; }
        public User User { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public List<Message> Messages { get; set; }
    }
}
