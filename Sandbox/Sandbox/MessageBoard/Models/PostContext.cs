using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Topics> Topics { get; set; }
    }
}
