using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer
{
    public class Response
    {
        public int QId { get; set; }
        public Question.Answer Answer { get; set; }
    }
}
