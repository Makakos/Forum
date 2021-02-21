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
    public class EFTopicsRepository:ITopicsRepository
    {
        private readonly ForumDBContext forumdbContext;

        public EFTopicsRepository(ForumDBContext context)
        {
            this.forumdbContext = context;
        }

        public IQueryable<Topic> GetTopics()
        {
            try
            {
                return this.forumdbContext.Topics;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        public Topic GetTopicById(int id)
        {
            return this.forumdbContext.Topics.Include(x => x.Discussions).FirstOrDefault(x => x.Id == id);
        }

        public void SaveTopic(Topic entity)
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

        public void DeleteTopicById(int id)
        {
            this.forumdbContext.Topics.Remove(new Topic { Id = id });
            this.forumdbContext.SaveChanges();
        }

        public void DeleteTopic(Topic topic)
        {
            this.forumdbContext.Entry(topic).State = EntityState.Deleted;
            this.forumdbContext.SaveChanges();
        }
    }
}
