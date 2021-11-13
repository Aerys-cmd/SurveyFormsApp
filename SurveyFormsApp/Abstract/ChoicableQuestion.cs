using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models.Abstract
{
    public abstract class ChoicableQuestion : Question
    {
        protected ChoicableQuestion(string name, QuestionType questionType) : base(name, questionType)
        {
        }

        protected HashSet<Option> options = new();
        public IReadOnlySet<Option> Options => options;
        public abstract void AddOption(Option option);

    }
}
