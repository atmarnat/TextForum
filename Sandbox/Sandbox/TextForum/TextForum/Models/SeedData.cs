using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace TextForum.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Posts.Any())
            {
                context.Posts.AddRange
                (
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
                    },
                    new Post
                    {
                        TopicID = 1,
                        UserID = 1,
                        Created = DateTime.Now,
                        Content = "Fourth Post"
                    },
                    new Post
                    {
                        TopicID = 1,
                        UserID = 1,
                        Created = DateTime.Now,
                        Content = "Fifth Post"
                    },
                    new Post
                    {
                        TopicID = 1,
                        UserID = 1,
                        Created = DateTime.Now,
                        Content = "Sixth Post"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange
                (
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
                );
                context.SaveChanges();
            }
            if (!context.Topics.Any())
            {
                context.Topics.AddRange
                (
                    new Topic
                    {
                        TopicName = "Entertainment"
                    },
                    new Topic
                    {
                        TopicName = "Programming"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
