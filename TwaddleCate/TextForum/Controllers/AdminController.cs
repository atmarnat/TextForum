using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextForum.Models;
using TextForum.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace TextForum.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IPostRepository repository;
        private readonly ApplicationDbContext _dbContext;

        public AdminController(IPostRepository repo, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(
                new AdminListViewModel
                {
                    Posts = repository.Posts,
                    Replies = repository.Replies
                }
            );
        }

        [HttpPost]
        public IActionResult DeleteP(int postID)
        {
            repository.DeletePost(postID);
            repository.DeletePostReply(postID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteR(int postID)
        {
            repository.DeleteReply(postID);
            return RedirectToAction("Index");
        }
    }
}