using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionServer.Managers
{
    public class QuestionsManager
    {
        private List<Question> _questions;
        private Dictionary<string, Student> _students;

        public QuestionsManager()
        {
            _questions = new List<Question>();
            _questions.Add(new Question(1));
            _questions.Add(new Question(2));
            _questions.Add(new Question(3));
            _questions.Add(new Question(4));
            _students = new Dictionary<string, Student>();
        }

        public List<Question> GetAll()
        {
            return new List<Question>(_questions);
        }

        public List<Answers> GetAllAnswers()
        {
            List<Answers> answerList = new List<Answers>();
            foreach (Question question in _questions)
            {
                answerList.Add(question.Answers);
            }
            return answerList;
        }

        public void HandleResponse(Response response, string ip)
        {
            bool valid = true;
            foreach (Student student in _students.Values)
            {
                if (ip == student.IP)
                {
                    valid = false;
                }
            }
            if (valid)
            {
                Student student = new Student(ip);
                _students.Add(ip, student);
                student.Answers.Add(response.QId, response.Answer);
            }
            else
            {
                _students[ip].Answers.Add(response.QId, response.Answer);
            }
            foreach (Question question in _questions)
            {
                if (question.Id == response.QId)
                {
                    switch (response.Answer)
                    {
                        case Question.Answer.a:
                            question.Answers.AnswerA++;
                            break;
                        case Question.Answer.b:
                            question.Answers.AnswerB++;
                            break;
                        case Question.Answer.c:
                            question.Answers.AnswerC++;
                            break;
                    }
                }
            }
        }
    }
}
