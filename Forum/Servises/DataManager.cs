using Forum.Repositories.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Servises
{
    public class DataManager
    {
        public IUsersRepository usersRepository;
        public ITopicsRepository topicsRepository;
        public IDiscussionsRepository discussionsRepository;
        public IMessagesRepository messagessRepository;


        public DataManager(IUsersRepository usesrs, ITopicsRepository topics, IDiscussionsRepository discussions, IMessagesRepository messages)
        {
            usersRepository = usesrs;
            topicsRepository = topics;
            discussionsRepository = discussions;
            messagessRepository = messages;
        }
    }
}
