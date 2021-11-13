using SurveyFormsApp.Abstract;
using SurveyFormsApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class MultipleChoiceQuestion : ChoicableQuestion, IAnswer<Option>
    {
        public MultipleChoiceQuestion(string name) : base(name, Abstract.QuestionType.MultipleChoice)
        {
        }

        public Option Answer { get; private set; }
        public void AddAnswer(Option answer)
        {
           var  isExist = Options.Any(x => x.Name == answer.Name);
            if (isExist)
            {
                if (answer == null)
                {
                    throw new Exception("Seçenek boş geçilemez.");
                }
                if (Answer!=null)
                {
                    Answer.isSelected = false;
                }
                answer.isSelected = true;
                Answer = answer;
            }
           
        }

        public override void AddOption(Option option)
        {
            var isSame = Options.Any(x => x.Name == option.Name);
            if (!isSame)
            {
                if (Options.Count < 4)
                {
                    options.Add(option);
                }
                else
                {
                    throw new Exception("Çoktan seçmeli soru tipinde sadece 4 adet seçenek bulunabilir.");
                }
            }
            else
            {
                throw new Exception("Daha önce aynı seçeneği yolladınız.");
            }

        }
    }
}
