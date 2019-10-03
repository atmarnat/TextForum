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
        IQueryable<User> Users { get; }
        IQueryable<Replies> Replies { get; }
    }
}
