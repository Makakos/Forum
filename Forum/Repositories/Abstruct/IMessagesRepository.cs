using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Repositories.Abstruct
{
    public interface IMessagesRepository
    {
        IQueryable<Message> GetMessages();

        Message GetMessageById(int id);

        void SaveMessage(Message entity);

        void DeleteMessageById(int id);

        void DeleteMessage(Message message);
    }
}
