using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer
{
    public class Question
    {
        public enum Answer
        {
            a, b, c
        }

        public int Id { get; init; }
        public Answers Answers { get; init; }

        public Question()
        {
            //Answers = new Answers();
            //Answers.QId = Id;
        }

        public Question(int id)
        {
            Id = id;
            Answers = new Answers();
            Answers.QId = Id;
        }
    }
}
