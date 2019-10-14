using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models
{
    public class EFPostRepository : IPostRepository
    {
        private ApplicationDbContext context;

        public EFPostRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Post> Posts => context.Posts;
        public IQueryable<Topic> Topics => context.Topics;
        public IQueryable<Replies> Replies => context.Replies;

        public Post DeletePost(int PostID)
        {
            Post dbEntry = context.Posts
                .FirstOrDefault(p => p.PostID == PostID);
            if (dbEntry != null)
            {
                context.Posts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public Replies DeletePostReply(int PostID)
        {
            Replies dbEntry = context.Replies
                .FirstOrDefault(p => p.PostID == PostID);
            if (dbEntry != null)
            {
                context.Replies.Remove(dbEntry);
                context.SaveChanges();
                DeletePostReply(PostID);
            }
            return dbEntry;
        }

        public Replies DeleteReply(int replyID)
        {
            Replies dbEntry = context.Replies
                .FirstOrDefault(p => p.ReplyID == replyID);
            if (dbEntry != null)
            {
                context.Replies.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
