using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TextForum.Models;
using TextForum.Models.ViewModels;

namespace TextForum.Controllers
{
    public class RepliesController : Controller
    {
        private IPostRepository repository;
        private readonly ApplicationDbContext _dbContext;

        public RepliesController(IPostRepository repo, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            repository = repo;
        }

        // GET: Replies
        public IActionResult List(int id)
            => View(new ReplyListViewController
            {
                Replies = repository.Replies
                    .Where(r => r.PostID == id),
                Topics = repository.Topics,
                FirstPost = repository.Posts
                    .Where(p => p.PostID == id)
                    .FirstOrDefault(),
                CurrentUserName = repository.Users
                    .Where(u => u.UserID == 1)
                    .Select(u => u.UserName)
                    .FirstOrDefault(),
                CurrentTopic = repository.Posts
                    .Where(p => p.PostID == id)
                    .Select(p => p.TopicID)
                    .FirstOrDefault(),
                CurrentTopicName = repository.Topics
                    .Join(repository.Posts,
                        t => t.TopicID,
                        p => p.TopicID,
                        (t, p) => new { Topic = t, Post = p})
                    .Where(tp => tp.Post.PostID == id)
                    .Select(tp => tp.Topic.TopicName)
                    .FirstOrDefault()
            });
        // GET: Replies/Create
        [HttpPost]
        public IActionResult Reply(Replies newReply)
        {
            if (newReply.ImgUrl != null)
            {
                MD5 md5Hash = MD5.Create();
                string imgPath = "wwwroot/Images/";
                string imgName = GetMd5Hash(md5Hash, newReply.Created + DateTime.UtcNow.ToString());
                string[] pathAndExtension = newReply.ImgUrl.Split('.');
                string extension = "." + pathAndExtension.Last();

                string fullpath = imgPath + imgName + extension;
                if (extension == ".jpg" || extension == ".gif" || extension == ".webm" || extension == ".jpeg" || extension == ".png")
                {
                    System.IO.File.Copy(newReply.ImgUrl, fullpath);
                    newReply.ImgUrl = imgName + extension;
                }
                else
                {
                    newReply.ImgUrl = null;
                }
            }

            _dbContext.Replies.Add(newReply);
            _dbContext.SaveChanges();
            return RedirectToAction("List", new { id = newReply.PostID });
        }

        [HttpGet]
        public IActionResult Reply()
        {
            return RedirectToAction("List");
        }
        public IActionResult NavMenu()
        {
            return RedirectToAction("List", "Topic");
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
