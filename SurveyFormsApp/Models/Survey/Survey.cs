using SurveyFormsApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models.Survey
{
    public class Survey
    {
        public Survey(string name, int numberOfQuestions, DateTime surveyDate)
        {
            ValidateSurveyCredentials(name, numberOfQuestions, surveyDate);
            Name = name;
            NumberOfQuestions = numberOfQuestions;
            SurveyDate = surveyDate;

        }

        private void ValidateSurveyCredentials(string name,int numberOfQuestions,DateTime surveyDate)
        {
            if (name=="")
            {
                throw new Exception("Anket başlığı boş geçilemez");
            }
            if (numberOfQuestions<=0)
            {
                throw new Exception("Ankete girilebilecek soru sayısı 0 veya 0 dan küçük olamaz");
            }
            if (surveyDate==default(DateTime))
            {
                throw new Exception("Anket tarihi boş geçilemez");
            }
        }

        public string Name { get; private set; }
        public int NumberOfQuestions { get; private set; }
        public DateTime SurveyDate { get; private set; }
        public string Description { get; private set; }
        public User User { get; private set; }
        public IReadOnlyList<Question> Questions => questions;
        private List<Question> questions { get; set; } = new();

        public void AddQuestion(Question question)
        {
            if (Questions.Count() < NumberOfQuestions)
            {
                var isSame = Questions.Any(x => x.Name == question.Name && x.QuestionType == question.QuestionType);
                if (!isSame)
                {
                    questions.Add(question);
                }
                else
                {
                    throw new Exception("Aynı türde ve aynı adda bir soru girilemez.");
                }
            }
            else
            {
                throw new Exception("Belirlediğiniz soru sayısının dışına çıkamazsınız");
            }

        }

        public void SetUser(User user)
        {
            User = user;
        }
        public void SetDescription(string description)
        {
            if (description=="")
            {
                throw new Exception("Açıklama alanı boş geçilemez");
            }
            Description = description;
        }
    }
}
