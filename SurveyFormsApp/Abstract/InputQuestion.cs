using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models.Abstract
{
    public abstract class InputQuestion : Question
    {
        protected InputQuestion(string name, QuestionType questionType) : base(name, questionType)
        {
        }
    }
}
