using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models
{
    public class FakePostRepository : IPostRepository
    {
        public IQueryable<Post> Posts => new List<Post>
        {
            new Post
            {
                TopicID = 1,
                UserID = 1,
                Created = DateTime.Now,
                Content = "First Post"
            },
            new Post
            {
                TopicID = 1,
                UserID = 1,
                Created = DateTime.Now,
                Content = "Second Post"
            },
            new Post
            {
                TopicID = 1,
                UserID = 1,
                Created = DateTime.Now,
                Content = "Third Post"
            }
        }.AsQueryable<Post>();
        public IQueryable<User> Users => new List<User>
        {
            new User
            {
                UserName = "anonymous,",
                Email = "n/a",
                UserPassword = "",
                UserPermissions = "000",
                UserPhoto = "link/to/here"
            },
            new User
            {
                UserName = "Admin,",
                Email = "abc@xyz.com",
                UserPassword = "password",
                UserPermissions = "111",
                UserPhoto = "link/to/there"
            }
        }.AsQueryable<User>();
        public IQueryable<Topic> Topics => new List<Topic>
        {
            new Topic
            {
                TopicName = "Entertainment"
            },
            new Topic
            {
                TopicName = "Programming"
            }
        }.AsQueryable<Topic>();
    }
}
