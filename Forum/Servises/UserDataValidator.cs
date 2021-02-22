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
            string emailPattern = "^[A-Za-z][A-Za-z0-9]*@[a-z]*.com";
           
            //string phonePattern = @"+380\d{9}";

            if (!Regex.IsMatch(user.Email, emailPattern))
            {
                errors.Add(new IdentityError { Description = $"Email {user.Email} is not available"});
            }
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
