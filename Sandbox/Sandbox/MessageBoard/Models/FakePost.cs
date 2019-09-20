using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public class FakePost
    {
        //This just sets values so I don't have to worry about being on a database
        public int PostID { get; set; } = 0;
        public int TopicID { get; set; } = 1;
        public int UserID { get; set; } = 1;
        public DateTime Created { get; set; } = DateTime.Now;
        public string Content { get; set; } = "Sample message";
    }
}
