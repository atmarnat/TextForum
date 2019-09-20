using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Posts
    {
        [Key]
        public int postID { get; set; }
        [Display(Name = "Topic")]
        public int topicID { get; set; }
        [Display(Name = "User")]
        public int userID { get; set; }
        [Display(Name = "Date Created")]
        public DateTime created { get; set; }
        [Display(Name = "Content")]
        public string content { get; set; }
    }
}
