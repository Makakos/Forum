
using Forum.Models;
using Forum.Repositories.Abstruct;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Repositories.EntityFramework
{
    public class EFDiscussionsRepository:IDiscussionsRepository
    {
        private readonly ForumDBContext forumdbContext;

        public EFDiscussionsRepository(ForumDBContext context)
        {
            this.forumdbContext = context;
        }

        public IQueryable<Discussion> GetDiscussions()
        {
            try
            {
                return this.forumdbContext.Discussions;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        public Discussion GetDiscussionById(int id)
        {
            return this.forumdbContext.Discussions.Include(x => x.Messages).ThenInclude(x=>x.User).FirstOrDefault(x => x.Id == id);
        }

        public void SaveDiscussion(Discussion entity)
        {
            if (entity.Id == default)
            {
                this.forumdbContext.Entry(entity).State = EntityState.Added;
            }
            else
            {
                this.forumdbContext.Entry(entity).State = EntityState.Modified;
            }

            this.forumdbContext.SaveChanges();
        }

        public void DeleteDiscussionById(int id)
        {
            this.forumdbContext.Discussions.Remove(new Discussion { Id = id });
            this.forumdbContext.SaveChanges();
        }

        public void DeleteDiscussion(Discussion discussion)
        {
            this.forumdbContext.Entry(discussion).State = EntityState.Deleted;
            this.forumdbContext.SaveChanges();
        }
    }
}
