using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class User : IdentityUser
    {
        public int Years { get; set; }
        public byte[] Avatar { get; set; }
        public List<Message> Messages { get; set; }
        public List<Discussion> Discussions { get; set; }
    }
}
