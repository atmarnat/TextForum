using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
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
                    Topics = repository.Topics
                });
            }
        }

        //Lets me use the create window in Views/Shared/Create
        //It takes in a post model, adds that to the list of posts in the database
        //Saves those changes to the database
        //Finally redirects back to the same page currently on, with the parameter for the topic id of the new post.
        [HttpPost]
        [RequestSizeLimit(10000000)]
        public async Task<IActionResult> Create(Post newPost)
        {
            if (newPost.Content != null)
            {
                var file = HttpContext.Request.Form.Files;
                bool uploadSuccess = false;
                string uploadedUri = null;

                if (file.Count != 0)
                {

                    //string imgPath = "wwwroot/Images/";
                    string imgName = Guid.NewGuid().ToString();
                    string extension = "";
                    for (int i = file[0].FileName.Length - 1; i > 0; i--)
                    {
                        if (file[0].FileName[i] == '.') break;
                        extension = file[0].FileName[i].ToString() + extension;
                    }

                    //string fullpath = imgPath + imgName + extension;
                    if (extension == "jpg" || extension == "gif" || extension == "webm" || extension == "jpeg" || extension == "png")
                    {
                        /*
                        using (var fileStream = new FileStream(fullpath, FileMode.Create))
                        {
                            file[0].CopyTo(fileStream);
                        }
                        newPost.ImgUrl = imgName + extension;
                        */
                        newPost.ImgUrl = imgName + '.' + extension;
                        using (var stream = file[0].OpenReadStream())
                        {
                            (uploadSuccess, uploadedUri) = await UploadToBlob(newPost.ImgUrl, stream, extension);
                            TempData["uploadedUri"] = uploadedUri;
                        }
                    }
                    else
                    {
                        newPost.ImgUrl = null;
                    }
                }
                _dbContext.Posts.Add(newPost);
                _dbContext.SaveChanges();
            }
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