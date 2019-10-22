using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models.ViewModels
{
    public class AdminListViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Replies> Replies { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public PagingInfo PagingInfoR { get; set; }
    }
}
