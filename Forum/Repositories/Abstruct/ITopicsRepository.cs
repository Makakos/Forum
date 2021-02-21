using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Repositories.Abstruct
{
    public interface ITopicsRepository
    {
        IQueryable<Topic> GetTopics();

        Topic GetTopicById(int id);

        void SaveTopic(Topic entity);

        void DeleteTopicById(int id);

        void DeleteTopic(Topic topic);
    }
}
