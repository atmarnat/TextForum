using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public class EFTopicRepository : ITopicRepository
    {
        private PostContext context;
        public EFTopicRepository(PostContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Topic> Topics => context.Topics;
    }
}
