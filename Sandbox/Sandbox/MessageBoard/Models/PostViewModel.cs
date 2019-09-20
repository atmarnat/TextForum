using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class PostViewModel
    {
        [Key]
        public int postID { get; }
        public int topicID { get; set; }
        public int userID { get; set; }
        public DateTime created { get; set; }
        public string content { get; set; }
    }
}
