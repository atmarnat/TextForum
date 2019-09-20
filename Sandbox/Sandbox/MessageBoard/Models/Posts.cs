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
        public int PostID { get; set; }
        [Display(Name = "Topic")]
        public int TopicID { get; set; }
        [Display(Name = "User")]
        public int UserID { get; set; }
        [Display(Name = "Date Created")]
        public DateTime Created { get; set; }
        [Display(Name = "Content")]
        public string Content { get; set; }
    }
}
