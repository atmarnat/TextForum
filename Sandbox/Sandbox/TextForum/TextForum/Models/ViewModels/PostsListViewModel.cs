using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextForum.Models;

namespace TextForum.Models.ViewModels
{
    public class PostsListViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
