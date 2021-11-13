using SurveyFormsApp.Abstract;
using SurveyFormsApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class YesNoQuestion : InputQuestion, IAnswer<bool>
    {
        public YesNoQuestion(string name) : base(name, Abstract.QuestionType.YesNo)
        { 
        }

        public bool Answer { get; set; }

        public void AddAnswer(bool answer)
        {
            Answer = answer;
        }
    }
}
