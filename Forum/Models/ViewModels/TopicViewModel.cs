using Forum.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models.ViewModels
{
    public class TopicViewModel
    {
        public Dictionary<Discussion,Message> discussAndLastMess { get; set; }
        public Topic Topic{get;set;}

        
        public TopicViewModel(DataManager dataManager,int id)
        {
            Topic = dataManager.topicsRepository.GetTopicById(id);
            var discussions = dataManager.topicsRepository.GetTopicById(id).Discussions;
            
            discussAndLastMess = new Dictionary<Discussion, Message>();

            foreach(Discussion discussion in discussions)
            {
                 Message temp=dataManager.discussionsRepository.GetDiscussionById(discussion.Id)
                    .Messages.LastOrDefault();

                if(temp!=null)
                    discussAndLastMess.Add(discussion, temp);
                else
                    discussAndLastMess.Add(discussion, new Message());
            }
          
        }
    }
}
