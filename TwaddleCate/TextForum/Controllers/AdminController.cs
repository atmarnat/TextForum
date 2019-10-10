using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextForum.Models;

namespace TextForum.Controllers
{
    public class AdminController : Controller
    {
        private IPostRepository repository;

        public AdminController(IPostRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Posts);
        }

        [HttpPost]
        public IActionResult Delete(int postID)
        {
            Post deletePost = repository.DeletePost(postID);
            if(deletePost != null)
            {
                TempData["message"] = $"{deletePost.PostID} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}