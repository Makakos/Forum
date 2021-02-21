using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Repositories.Abstruct
{
    public interface IDiscussionsRepository
    {
        IQueryable<Discussion> GetDiscussions();

        Discussion GetDiscussionById(int id);

        void SaveDiscussion(Discussion entity);

        void DeleteDiscussionById(int id);

        void DeleteDiscussion(Discussion topic);
    }
}
