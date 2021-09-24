using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionServer.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuestionServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        public QuestionsManager _manager = new QuestionsManager();
        // GET: api/<QuestionsController>
        [HttpGet]
        public ActionResult<IEnumerable<Answers>> Get()
        {
            List<Answers> answers = _manager.GetAllAnswers();
            if (answers.Count > 0)
            {
                return Ok(answers);
            }
            return NoContent();
        }

        // POST api/<QuestionsController>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPost]
        public ActionResult Post([FromBody] Response response)
        {
            _manager.HandleResponse(response, GetClientIP());
            return NoContent();
        }

        public string GetClientIP()
        {
            return HttpContext.Connection.RemoteIpAddress.ToString();
        }
    }
}
