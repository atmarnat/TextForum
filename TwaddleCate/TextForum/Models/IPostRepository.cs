using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }
        IQueryable<Topic> Topics { get; }
        IQueryable<Replies> Replies { get; }

        Post DeletePost(int PostID);
        Replies DeleteReply(int ReplyID);
        Replies DeletePostReply(int postID);
    }
}
