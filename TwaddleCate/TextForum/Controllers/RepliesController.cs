using System;
using System.Collections.Generic;
using System.IO;
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
            if (newReply.Content != null)
            {
                var file = HttpContext.Request.Form.Files;
                if (file.Count != 0)
                {
                    MD5 md5Hash = MD5.Create();
                    string imgPath = "wwwroot/Images/";
                    string imgName = Guid.NewGuid().ToString();
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
                        newReply.ImgUrl = imgName + extension;
                    }
                    else
                    {
                        newReply.ImgUrl = null;
                    }
                }

                _dbContext.Replies.Add(newReply);
                _dbContext.SaveChanges();
            }
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
    }
}
