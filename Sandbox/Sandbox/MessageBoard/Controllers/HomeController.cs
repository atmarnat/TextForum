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
            var _postList = _dbContext.Posts
            .Join(_dbContext.Users, p => p.UserID, u => u.UserID,
            (p, u) => new PostViewModel
            {
                postID = p.PostID,
                user = u.UserName,
                created = DateTime.Now,
                content = p.Content
            }).ToList();
                
            IList<PostViewModel> postList = _postList;

            return View(postList);
        }
    }
}
