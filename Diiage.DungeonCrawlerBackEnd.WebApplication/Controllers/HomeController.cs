using Diiage.DungeonCrawlerBackEnd.WebApplication.Hubs;
using Diiage.DungeonCrawlerBackEnd.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {

        private static string test = "";
        //private IPotionBusiness _potion;

        private readonly IHubContext<HomeHub> hubContext;
        public HomeController(IHubContext<HomeHub> homeHub)
        {
            this.hubContext = homeHub;
        }


        public IActionResult Index()
        {
            return View();
        }
        
        private static ConcurrentBag<Question> questions = new ConcurrentBag<Question> {
        new Question {
            Id = Guid.Parse("b00c58c0-df00-49ac-ae85-0a135f75e01b"),
            Title = "Welcome",
            Body = "Welcome to the _mini Stack Overflow_ rip-off!\nThis will help showcasing **SignalR** and its integration with **Vue**",
            Answers = new List<Answer>{ new Answer { Body = "Sample answer" }}
        }
        };
        [HttpGet()]
        public IEnumerable GetQuestions()
        {
            return questions.Select(q => new {
                Id = q.Id,
                Title = q.Title,
                Body = q.Body,
                Score = q.Score,
                AnswerCount = q.Answers.Count
            });
        }
        [HttpGet("{id}")]
        public ActionResult GetQuestion(Guid id)
        {
            var question = questions.SingleOrDefault(t => t.Id == id);
            if (question == null) return NotFound();

            return new JsonResult(question);
        }
        [HttpPost()]
        public Question AddQuestion([FromBody] Question question)
        {
            question.Id = Guid.NewGuid();
            question.Answers = new List<Answer>();
            questions.Add(question);
            return question;
        }
        [HttpPost("{id}/answer")]
        public ActionResult AddAnswerAsync(Guid id, [FromBody] Answer answer)
        {
            var question = questions.SingleOrDefault(t => t.Id == id);
            if (question == null) return NotFound();

            answer.Id = Guid.NewGuid();
            answer.QuestionId = id;
            question.Answers.Add(answer);
            return new JsonResult(answer);
        }
        [HttpPatch("{id}/upvote")]
        public async Task<ActionResult> UpvoteQuestionAsync(Guid id)
        {
            var question = questions.SingleOrDefault(t => t.Id == id);
            if (question == null) return NotFound();

            // Warning, this increment isnt thread-safe! Use Interlocked methods
            question.Score++;

            await this.hubContext
              .Clients
              .All
              .SendAsync("QuestionScoreChange", question.Id, question.Score);

            return new JsonResult(question);
        }
    }
}
