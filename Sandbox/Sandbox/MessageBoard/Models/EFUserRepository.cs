using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public class EFUserRepository : IUserRepository
    {
        private PostContext context;
        public EFUserRepository(PostContext ctx)
        {
            context = ctx;
        }
        public IQueryable<User> Users => context.Users;
    }
}
