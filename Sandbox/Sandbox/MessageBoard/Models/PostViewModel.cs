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
        public int postID { get; set; }
        public string topic { get; set; }
        public string user { get; set; }
        public DateTime created { get; set; }
        public string content { get; set; }
    }
}
