using System;
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

        //Renders the Topic view, based on a required id(which is related to the topic id),
        //optional search parameter(to filter stuff), and pagination
        public ViewResult List(int id, string search = null, int postPage = 1)
        {
            //This is the default view of the page, or what happens when you search an empty string
            if (search == null)
            {
                return View(new PostsListViewModel
                {
                    //Makes a list of posts based on the topic ID, orders from newest to oldest
                    Posts = repository.Posts
                          .OrderByDescending(p => p.Created)
                          .Where(p => p.TopicID == id)
                          .Skip((postPage - 1) * PageSize)
                          .Take(PageSize),
                    //Pagination stuff
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = postPage,
                        PostsPerPage = PageSize,
                        TotalPosts = repository.Posts
                              .Where(e => e.TopicID == id)
                              .Count()
                    },
                    //Lets us easily work with the topic ID, more for consistency
                    CurrentTopic = id,
                    //Finds the topic name in Topic list based on the ID, then returns the first hit (there is only 1)
                    CurrentTopicName = repository.Topics
                          .Where(t => t.TopicID == id)
                          .Select(t => t.TopicName)
                          .First(),
                    //Same thing as above, but for userID. Always anonymous for now
                    //TODO: for when we get users
                    CurrentUserName = repository.Users
                          .Where(u => u.UserID == 1)
                          .Select(u => u.UserName)
                          .First(),
                    //Gets the full list of topics, so that the NavMenu can easily display them
                    Topics = repository.Topics
                });
            }
            //This part works like the part above it, but also includes filters for the search term
            else
            {
                return View(new PostsListViewModel
                {
                    Posts = repository.Posts
                      .OrderByDescending(p => p.Created)
                      .Where(p => p.TopicID == id && p.Content.Contains(search))
                      .Skip((postPage - 1) * PageSize)
                      .Take(PageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = postPage,
                        PostsPerPage = PageSize,
                        TotalPosts = repository.Posts
                          .Where(e => e.TopicID == id && e.Content.Contains(search))
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
            }
        }

        //Lets me use the create window in Views/Shared/Create
        //It takes in a post model, adds that to the list of posts in the database
        //Saves those changes to the database
        //Finally redirects back to the same page currently on, with the parameter for the topic id of the new post.
        [HttpPost]
        public IActionResult Create(Post newPost)
        {
            _dbContext.Posts.Add(newPost);
            _dbContext.SaveChanges();
            return RedirectToAction("List", new {id = newPost.TopicID});
        }

        //Lets me use the create window in Views/Shared/Create
        //This one isn't used atm. Can ignore it
        [HttpGet]
        public IActionResult Create()
        {
            return RedirectToAction("List");
        }

        //Lets me use the navigation window in Views/Shared/NavMenu
        public IActionResult NavMenu()
        {
            return RedirectToAction("List");
        }
    }
}