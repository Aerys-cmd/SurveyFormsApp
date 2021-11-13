using SurveyFormsApp.Abstract;
using SurveyFormsApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class DateQuestion : InputQuestion, IAnswer<DateTime>
    {
        public DateQuestion(string name) : base(name, Abstract.QuestionType.DateQuestion)
        {
        }

        public DateTime Answer { get; set; }
        public void AddAnswer(DateTime answer)
        {
            if (answer != default(DateTime))
            {
                Answer = answer;
            }
            else
            {
                throw new Exception("Tarih boş geçilemez");
            }

        }
    }
}
