using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public class EFPostRepository : IPostRepository
    {
        private PostContext context;
        public EFPostRepository(PostContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Post> Posts => context.Posts;
    }
}
