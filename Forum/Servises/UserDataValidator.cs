using Forum.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Forum.Servises
{
    public class UserDataValidator : IUserValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
        {
            List<IdentityError> errors = new List<IdentityError>();
            string mailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            //string phonePattern = @"+380\d{9}";

            //if(!Regex.IsMatch(user.Email,mailPattern))
            //{
            //    errors.Add(new IdentityError { Description = "You entered wrong email" });
            //}
            //if (!Regex.IsMatch(user.PhoneNumber, phonePattern))
            //{
            //    errors.Add(new IdentityError { Description = "You entered wrong phone" });
            //}
            if (user.UserName.Contains("admin"))
            {
                errors.Add(new IdentityError { Description = "User name may not contain the word 'admin'" });
            }
            return Task.FromResult(errors.Count == 0 ?
                IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}
