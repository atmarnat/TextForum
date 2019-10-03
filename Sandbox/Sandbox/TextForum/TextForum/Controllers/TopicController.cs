﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextForum.Models;
using TextForum.Models.ViewModels;

namespace TextForum.Controllers
{
    public class TopicController : Controller
    {
        private IPostRepository repository;
        private readonly ApplicationDbContext _dbContext;

        public int PageSize = 10;
        public TopicController(IPostRepository repo, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            repository = repo;
        }
        public ViewResult List(int id, int postPage = 1)
            => View(new PostsListViewModel
            { 
                Posts = repository.Posts
                    .OrderByDescending(p => p.Created)
                    .Where(p => p.TopicID == id)
                    .Skip((postPage -1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = postPage,
                    PostsPerPage = PageSize,
                    TotalPosts = repository.Posts
                        .Where (e => e.TopicID == id)
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

        [HttpPost]
        public IActionResult Create(Post newPost)
        {
            _dbContext.Posts.Add(newPost);
            _dbContext.SaveChanges();
            return RedirectToAction("List", new {id = newPost.TopicID});
        }

        [HttpGet]
        public IActionResult Create()
        {
            return RedirectToAction("List");
        }

        public IActionResult NavMenu()
        {
            return RedirectToAction("List");
        }
    }
}