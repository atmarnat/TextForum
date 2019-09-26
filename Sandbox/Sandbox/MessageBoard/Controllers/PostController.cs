using MessageBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Controllers
{
    public class PostController : Controller
    {
        private readonly PostContext _dbContext;
        private IPostRepository repository;

        public PostController (IPostRepository repo, PostContext dbContext)
        {
            repository = repo;
            _dbContext = dbContext;
        }

        public ViewResult List() => View(repository.Posts);
        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public ViewResult AddPost(Post newPost)
        {
            _dbContext.Posts.Add(newPost);
            _dbContext.SaveChanges();
            return View();
        }

        /*
public IActionResult Index()
{
    var _postList = _dbContext.Posts
    .Join(_dbContext.Users, p => p.UserID, u => u.UserID,
    (p, u) => new PostViewModel
    {
        postID = p.PostID,
        user = u.UserName,
        created = p.Created,
        content = p.Content
    }).ToList();

    IList<PostViewModel> postList = _postList;

    return View(postList);
}
*/
    }
}
