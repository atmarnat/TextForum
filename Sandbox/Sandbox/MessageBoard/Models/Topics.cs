using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Topics
    {
        [Key]
        public int TopicID { get; set; }
        [Display(Name = "Topic")]
        public string Topic { get; set; }
    }
}
