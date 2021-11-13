using SurveyFormsApp.Abstract;
using SurveyFormsApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class ParagraphAnswerQuestion : InputQuestion, IAnswer<string>
    {
        public ParagraphAnswerQuestion(string name) : base(name, Abstract.QuestionType.ParagraphAnswer)
        {
        }

        public string Answer { get; private set; }
        public void AddAnswer(string answer)
        {
            if (answer.Length <= 200)
            {
                Answer = answer;
            }
            else
            {
                throw new Exception("Gönderdiğiniz veri 200 karakterden fazladır lütfen daha az karakter giriniz.");
            }

        }
    }
}
