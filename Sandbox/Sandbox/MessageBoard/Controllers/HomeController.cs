using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly PostContext _dbContext;

        public HomeController(PostContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var _postList = _dbContext.Posts.
                Join(_dbContext.Topics, p => p.TopicID, t => t.TopicID,
                (p, t) => new PostViewModel
                {
                    topic = t.Topic,
                    user = t.Topic,
                    created = DateTime.Now,
                    content = p.Content
                }).ToList();
            IList<PostViewModel> postList = _postList;

            return View(postList);
        }
    }
}
