using SurveyFormsApp.Abstract;
using SurveyFormsApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class ShortAnswerQuestion : InputQuestion, IAnswer<string>
     {
        public ShortAnswerQuestion(string name) : base(name, Abstract.QuestionType.ShortAnswer)
        {
        }

        public string Answer { get; private set; }
        public void AddAnswer(string answer)
        {
            if (answer.Length<=30)
            {
                Answer = answer;
            }
            else
            {
                throw new Exception("Kısa yanıt soru tipinde 30 karakterden fazla girilemez.");
            }
        }
    }
}
