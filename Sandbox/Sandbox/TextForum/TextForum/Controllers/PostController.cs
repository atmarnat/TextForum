using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextForum.Models;
using TextForum.Models.ViewModels;

namespace TextForum.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository repository;
        private readonly ApplicationDbContext _dbContext;

        public int PageSize = 10;
        public PostController(IPostRepository repo, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            repository = repo;
        }
        public ViewResult List(int postPage = 1)
            => View(new PostsListViewModel
            { 
                Posts = repository.Posts
                .OrderBy(p => p.PostID)
                .Skip((postPage -1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = postPage,
                    PostsPerPage = PageSize,
                    TotalPosts = repository.Posts.Count()
                }
            });

        [HttpPost]
        public ViewResult AddPost(Post newPost)
        {
            _dbContext.Posts.Add(newPost);
            _dbContext.SaveChanges();
            return View();
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}