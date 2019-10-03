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
                Replies = repository.Replies,
                Topics = repository.Topics,
                FirstPost = repository.Posts
                    .Where(p => p.PostID == id)
                    .First()
            });

        /*
        public ViewResult List(int id, int postPage = 1)
            => View(new PostsListViewModel
            {
                Posts = repository.Posts
                    .OrderByDescending(p => p.Created)
                    .Where(p => p.TopicID == id)
                    .Skip((postPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = postPage,
                    PostsPerPage = PageSize,
                    TotalPosts = repository.Posts
                        .Where(e => e.TopicID == id)
                        .Count()
                },
                CurrentTopic = id,
                CurrentTopicName = repository.Topics
                    .Where(t => t.TopicID == id)
                    .Select(t => t.TopicName)
                    .First(),
                CurrentUserName = repository.Users
                    .Where(u => u.UserID == 1)
                    .Select(u => u.UserName)
                    .First(),
                Topics = repository.Topics
            });
            */
        // GET: Replies/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult NavMenu()
        {
            return RedirectToAction("List", "Topic");
        }
    }
}
