using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public int TopicID { get; set; }
        public int UserID { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
    }
}
