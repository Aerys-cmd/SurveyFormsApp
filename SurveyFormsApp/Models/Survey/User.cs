using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models.Survey
{
    public class User
    {


        public string Name { get; private set; }
        public string Surname { get; private set; }
        public User(string name, string surname)
        {
            ValidateUserCredentials(name, surname);
            Name = name;
            Surname = surname;
        }
        private void ValidateUserCredentials(string name, string surname)
        {
            if (name == "")
            {
                throw new Exception("Ad alanı boş geçilemez");

            }
            if (surname == "")
            {
                throw new Exception("Soyad alanı boş geçilemez");
            }
        }
    }
}
