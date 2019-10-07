using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                      .Where(p => p.TopicID == id && (p.Content.Contains(search) || p.PostTitle.Contains(search)))
                      .Skip((postPage - 1) * PageSize)
                      .Take(PageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = postPage,
                        PostsPerPage = PageSize,
                        TotalPosts = repository.Posts
                          .Where(e => e.TopicID == id && (e.Content.Contains(search) || e.PostTitle.Contains(search)))
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
            var file = HttpContext.Request.Form.Files;
            if (file.Count != 0)
            {
                MD5 md5Hash = MD5.Create();
                string imgPath = "wwwroot/Images/";
                string imgName = GetMd5Hash(md5Hash, newPost.Created + DateTime.UtcNow.ToString());
                string extension = "";
                for (int i = file[0].FileName.Length - 1; i > 0; i--)
                {
                    extension = file[0].FileName[i].ToString() + extension;
                    if (file[0].FileName[i] == '.') break;
                }

                string fullpath = imgPath + imgName + extension;
                if (extension == ".jpg" || extension == ".gif" || extension == ".webm" || extension == ".jpeg" || extension == ".png")
                {
                    using (var fileStream = new FileStream(fullpath, FileMode.Create))
                    {
                        file[0].CopyTo(fileStream);
                    }
                    newPost.ImgUrl = imgName + extension;
                }
                else
                {
                    newPost.ImgUrl = null;
                }
            }

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
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}