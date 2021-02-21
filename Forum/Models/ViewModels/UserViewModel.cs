using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Forum.Models.ViewModels
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public IFormFile Avatar { get; set; }

    }
}


