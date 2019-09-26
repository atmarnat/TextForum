using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PostContext context = app.ApplicationServices.GetRequiredService<PostContext>();
            context.Database.Migrate();
            if(!context.Topics.Any())
            {
                context.Topics.AddRange
                (
                    new Topic
                    {
                        TopicName = "Sports"
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
                        UserPassword = "password",
                        Email = "abc@123.com",
                        UserPhoto = "string",
                        UserPermissions = "string",
                        UserName = "anonymous",
                    }
                );
                context.SaveChanges();
            }
            if (!context.Posts.Any())
            {
                context.Posts.AddRange
                (
                    new Post
                    {
                        TopicID = 1,
                        Created = DateTime.Now,
                        UserID = 1,
                        Content = "SeedData Post"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
