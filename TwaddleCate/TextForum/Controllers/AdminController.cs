using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextForum.Models;
using TextForum.Models.ViewModels;

namespace TextForum.Controllers
{
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
        public IActionResult Delete(int postID)
        {
            Post deletePost = repository.DeletePost(postID);
            Replies deleteReply = repository.DeleteReply(postID);
            if (deleteReply != null)
            {
                TempData["message"] = $"{deleteReply.ReplyID} was deleted";
            }

            if (deletePost != null)
            {
                TempData["message"] = $"{deletePost.PostID} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}