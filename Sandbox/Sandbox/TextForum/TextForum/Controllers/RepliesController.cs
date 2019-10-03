using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TextForum.Models;
using TextForum.Models.ViewModels;

namespace TextForum.Controllers
{
    public class RepliesController : Controller
    {
        private IPostRepository repository;
        private readonly ApplicationDbContext _dbContext;

        public RepliesController(IPostRepository repo, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            repository = repo;
        }

        // GET: Replies
        public IActionResult List(int id)
            => View(new ReplyListViewController
            {
                Replies = repository.Replies
                    .Where(r => r.PostID == id),
                Topics = repository.Topics,
                FirstPost = repository.Posts
                    .Where(p => p.PostID == id)
                    .First(),
                CurrentUserName = repository.Users
                    .Where(u => u.UserID == 1)
                    .Select(u => u.UserName)
                    .First(),
                CurrentTopic = repository.Posts
                    .Where(p => p.PostID == id)
                    .Select(p => p.TopicID)
                    .First(),
                CurrentTopicName = repository.Topics
                    .Join(repository.Posts,
                        t => t.TopicID,
                        p => p.TopicID,
                        (t, p) => new { Topic = t, Post = p})
                    .Where(tp => tp.Post.PostID == id)
                    .Select(tp => tp.Topic.TopicName)
                    .First()
            });
        // GET: Replies/Create
        [HttpPost]
        public IActionResult Reply(Replies newReply)
        {
            _dbContext.Replies.Add(newReply);
            _dbContext.SaveChanges();
            return RedirectToAction("List", new { id = newReply.PostID });
        }

        [HttpGet]
        public IActionResult Reply()
        {
            return RedirectToAction("List");
        }
        public IActionResult NavMenu()
        {
            return RedirectToAction("List", "Topic");
        }
    }
}
