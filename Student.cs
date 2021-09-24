using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer
{
    public class Student
    {
        public string IP { get; init; }
        public Dictionary<int, Question.Answer> Answers { get; init; }

        public Student(string ip)
        {
            IP = ip;
        }
    }
}
