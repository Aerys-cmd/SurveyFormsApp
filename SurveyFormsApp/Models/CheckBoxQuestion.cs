using SurveyFormsApp.Abstract;
using SurveyFormsApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class CheckBoxQuestion : ChoicableQuestion, IAnswer<Option>
    {


        public CheckBoxQuestion(string name) : base(name, Abstract.QuestionType.CheckBox)
        {
            options.Add(new Option("Hiçbiri"));
        }

        private List<Option> answers { get; set; } = new();
        public IReadOnlyList<Option> Answers => answers;
        public void AddAnswer(Option answer)
        {
            var isOption = options.Any(x => x.Name == answer.Name);
            var isSame = Answers.Any(x => x.Name == answer.Name);
            var isNone = answer.Name == "Hiçbiri" ? true : false;
            var isAfterNone = answers.Any(x => x.Name == "Hiçbiri");

            if (isOption)
            {
                if (!isSame)
                {
                    if (isNone)
                    {
                        answers.ForEach(x =>
                        {
                            x.isSelected = false;
                        });
                        answers.Clear();
                    }
                    else if (isAfterNone)
                    {
                        answers.ForEach(x =>
                        {
                            x.isSelected = false;
                        });
                        answers.Clear();
                    }
                    answer.isSelected = true;
                    answers.Add(answer);
                }
                else
                {
                    throw new Exception("Aynı seçeneği birden fazla kez seçemezsiniz.");
                }
            }
            else
            {
                throw new Exception("Soruya tanımlı böyle bir seçenek bulunamadı.");
            }


        }

        /// <summary>
        /// En fazla 5 adet Option eklenebilir.
        /// Kullanıcı tarafından sadece 4 adet eklenir.
        /// Hiçbiri option'ı sistem tarafından entegre edilir.
        /// </summary>
        /// <param name="option"></param>
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
