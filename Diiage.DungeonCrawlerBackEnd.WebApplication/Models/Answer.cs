using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Models
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string Body { get; set; }
    }
}
