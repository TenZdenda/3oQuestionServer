using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuestionServer
{
    public class Response
    {
        public int QId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Question.Answer Answer { get; set; }
    }
}
