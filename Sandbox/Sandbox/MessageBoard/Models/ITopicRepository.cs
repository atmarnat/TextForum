using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public interface ITopicRepository
    {
        IQueryable<Topic> Topics { get; }
    }
}
