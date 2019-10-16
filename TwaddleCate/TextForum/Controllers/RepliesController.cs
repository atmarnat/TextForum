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
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
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
        public async Task<IActionResult> Reply(Replies newReply)
        {
            if (newReply.Content != null)
            {
                bool uploadSuccess = false;
                string uploadedUri = null;
                var file = HttpContext.Request.Form.Files;

                if (file.Count != 0)
                {
                    string imgName = Guid.NewGuid().ToString();
                    string extension = "";
                    for (int i = file[0].FileName.Length - 1; i > 0; i--)
                    {
                        if (file[0].FileName[i] == '.') break;
                        extension = file[0].FileName[i].ToString() + extension;
                    }

                    if (extension == "jpg" || extension == "gif" || extension == "webm" || extension == "jpeg" || extension == "png")
                    {
                        newReply.ImgUrl = imgName + '.' + extension;
                        using (var stream = file[0].OpenReadStream())
                        {
                            (uploadSuccess, uploadedUri) = await UploadToBlob(newReply.ImgUrl, stream, extension);
                            TempData["uploadedUri"] = uploadedUri;
                        }
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

        private async Task<(bool, string)> UploadToBlob(string filename, Stream stream = null, string extension = "")
        {
            CloudStorageAccount storageAccount = null;
            CloudBlobContainer cloudBlobContainer = null;
            string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=imgrepository;AccountKey=hDp7VzQ6gODwXHSRqFmHJQBV94+kZmfG0GRyvNhVcwPxeV1UjJOOWXnaxOYVuA7kH2/zNxBZDZLusKkMhfjmsg==;EndpointSuffix=core.windows.net";

            // Check whether the connection string can be parsed.
            if (CloudStorageAccount.TryParse(storageConnectionString, out storageAccount))
            {
                try
                {
                    // Create the CloudBlobClient that represents the Blob storage endpoint
                    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

                    // Add to images container 
                    cloudBlobContainer = cloudBlobClient.GetContainerReference("images");

                    // Set the permissions so the blobs are public. 
                    BlobContainerPermissions permissions = new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Blob
                    };
                    await cloudBlobContainer.SetPermissionsAsync(permissions);

                    // Get a reference to the blob address, then upload the file to the blob.
                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(filename);


                    if (stream != null)
                    {
                        // Pass in memory stream directly
                        if (extension.Equals("webm"))
                        {
                            cloudBlockBlob.Properties.ContentType = "video/" + extension;
                        }
                        else
                        {
                            cloudBlockBlob.Properties.ContentType = "image/" + extension;
                        }
                        await cloudBlockBlob.UploadFromStreamAsync(stream);
                    }
                    else
                    {
                        return (false, null);
                    }

                    return (true, cloudBlockBlob.SnapshotQualifiedStorageUri.PrimaryUri.ToString());
                }
                catch (StorageException ex)
                {
                    return (false, null);
                }
            }
            else
            {
                return (false, null);
            }
        }
    }
}
