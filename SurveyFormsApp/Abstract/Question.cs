using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models.Abstract
{
    public enum QuestionType

    {
        CheckBox,ShortAnswer,DateQuestion,ParagraphAnswer,MultipleChoice,YesNo
    }
    public abstract class Question
    {
        public Question(string name,QuestionType questionType)
        {
            ValidateQuestionCredentials(name);
            Name = name;
            QuestionType = questionType.ToString();
        }
        public string Name { get; set; }
        public string QuestionType { get; set; }
        private void ValidateQuestionCredentials(string name )
        {
            if (name=="")
            {
                throw new Exception("Soru adı boş geçilemez");
            }
        }

      
    }
}
