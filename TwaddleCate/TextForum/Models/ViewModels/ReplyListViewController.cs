using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models.ViewModels
{
    public class ReplyListViewController
    {
        public IEnumerable<Replies> Replies { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public Post FirstPost { get; set; }
        public string CurrentUserName { get; set; }
        public int CurrentTopic { get; set; }
        public string CurrentTopicName { get; set; }
    }
}
