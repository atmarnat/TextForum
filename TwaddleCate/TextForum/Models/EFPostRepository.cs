using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextForum.Models
{
    public class EFPostRepository : IPostRepository
    {
        private ApplicationDbContext context;

        public EFPostRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Post> Posts => context.Posts;
        public IQueryable<Topic> Topics => context.Topics;
        public IQueryable<Replies> Replies => context.Replies;

        public Post DeletePost(int PostID)
        {
            Post dbEntry = context.Posts
                .FirstOrDefault(p => p.PostID == PostID);
            string tempUrl = dbEntry.ImgUrl;
            if (dbEntry != null)
            {
                context.Posts.Remove(dbEntry);
                context.SaveChanges();
                if (tempUrl != null)
                {
                    DeleteImageAsync(tempUrl);
                }
            }
            return dbEntry;
        }

        public Replies DeletePostReply(int PostID)
        {
            Replies dbEntry = context.Replies
                .FirstOrDefault(p => p.PostID == PostID);
            string tempUrl = dbEntry.ImgUrl;
            if (dbEntry != null)
            {
                context.Replies.Remove(dbEntry);
                context.SaveChanges();
                if (tempUrl != null)
                {
                    DeleteImageAsync(tempUrl);
                }
                DeletePostReply(PostID);
            }
            return dbEntry;
        }

        public Replies DeleteReply(int replyID)
        {
            Replies dbEntry = context.Replies
                .FirstOrDefault(p => p.ReplyID == replyID);
            string tempUrl = dbEntry.ImgUrl;
            if (dbEntry != null)
            {
                context.Replies.Remove(dbEntry);
                context.SaveChanges();
                if (tempUrl != null)
                {
                    DeleteImageAsync(tempUrl);
                }
            }
            return dbEntry;
        }

        public void DeleteImageAsync(string imgUrl)
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
                    cloudBlobContainer.SetPermissionsAsync(permissions);

                    // Get a reference to the blob address, then upload the file to the blob.
                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(imgUrl);
                    cloudBlockBlob.DeleteIfExistsAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
