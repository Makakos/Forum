using Forum.Models;
using Forum.Repositories.Abstruct;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Repositories.EntityFramework
{
    public class EFUsersRepository:IUsersRepository
    {
        private readonly ForumDBContext forumDBContext;

        public EFUsersRepository(ForumDBContext context)
        {
            this.forumDBContext = context;
        }

        public IQueryable<User> GetUsers()
        {
            return this.forumDBContext.Users.Include(x=>x.Discussions);
        }

        public User GetUserById(string id)
        {
            return this.forumDBContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public void SaveUser(User entity)
        {
            if (entity.Id == default)
            {
                this.forumDBContext.Entry(entity).State = EntityState.Added;
            }
            else
            {
                this.forumDBContext.Entry(entity).State = EntityState.Modified;
            }

            this.forumDBContext.SaveChanges();
        }
    }
}
