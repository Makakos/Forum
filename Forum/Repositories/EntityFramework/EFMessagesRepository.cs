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
    public class EFMessagesRepository:IMessagesRepository
    {
        private readonly ForumDBContext forumDBContext;

        public EFMessagesRepository(ForumDBContext context)
        {
            this.forumDBContext = context;
        }

        public IQueryable<Message> GetMessages()
        {
            try
            {
                return this.forumDBContext.Messages.Include(x=>x.User);
            }
            catch (SqlException ex)
            {
               
                return null;
            }
        }

      
        public Message GetMessageById(int id)
        {
            return this.forumDBContext.Messages.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMessage(Message entity)
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

        public void DeleteMessageById(int id)
        {
            this.forumDBContext.Messages.Remove(new Message { Id = id });
            this.forumDBContext.SaveChanges();
        }

        public void DeleteMessage(Message message)
        {
            this.forumDBContext.Entry(message).State = EntityState.Deleted;
            this.forumDBContext.SaveChanges();
        }
    }
}
