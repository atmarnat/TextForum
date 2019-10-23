using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalPosts { get; set; }
        public int PostsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public bool PostType { get; set; } = false;

        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalPosts / PostsPerPage);
    }
}
