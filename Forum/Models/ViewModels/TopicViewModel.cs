using Forum.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models.ViewModels
{
    public class TopicViewModel
    {
        
        public List<Discussion> discussions { get; set; }
        public List<Message> lastMessages { get; set; }
        public string TopicName{get;set;}

        
        public TopicViewModel(DataManager dataManager,int id)
        {
            TopicName = dataManager.topicsRepository.GetTopicById(id).Name;
            discussions = dataManager.topicsRepository.GetTopicById(id).Discussions;
            lastMessages = new List<Message>();
            

            foreach(Discussion discussion in discussions)
            {
                 lastMessages.Add(dataManager.discussionsRepository.GetDiscussionById(discussion.Id).Messages.
                                     OrderByDescending(x => x.Date).FirstOrDefault());
                 
            }
          
        }
    }
}
