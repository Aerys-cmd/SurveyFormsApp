using SurveyFormsApp.Models;
using SurveyFormsApp.Models.Survey;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveyFormsApp
{
    class Program
    {
        public static object Survay { get; private set; }

        static void Main(string[] args)
        {

            Survey survey = new Survey(name: "Genel Değerlendirme Formu - (GDF)", numberOfQuestions: 10, DateTime.Now.AddDays(5));

            //Soru 1 
            var check1 = new CheckBoxQuestion(name: "Hangi şehirleri ziyaret ettiniz.");
            check1.AddOption(new Option(name: "New York"));
            check1.AddOption(new Option(name: "Paris"));
            check1.AddOption(new Option(name: "Londra"));
            check1.AddOption(new Option(name: "Hong Kong"));

            check1.AddAnswer(new Option(name: "New York"));
            check1.AddAnswer(new Option(name: "Hong Kong"));
            check1.AddAnswer(new Option(name: "Londra"));
            check1.AddAnswer(new Option(name: "Paris"));
            check1.AddAnswer(new Option(name: "Hiçbiri"));
            check1.AddAnswer(new Option(name: "Londra"));
            check1.AddAnswer(new Option(name: "Paris"));

            foreach (var answer in check1.Answers)
            {
                Console.WriteLine(answer.Name);
                Console.WriteLine(answer.isSelected);
            }
            //Soru 2 
            var check2 = new CheckBoxQuestion(name: "Hangi renk size daha yakın geliyor.");
            check2.AddOption(new Option(name: "Mavi"));
            check2.AddOption(new Option(name: "Kırmızı"));
            check2.AddOption(new Option(name: "Kahverengi"));
            check2.AddOption(new Option(name: "Beyaz"));

            var multi1 = new MultipleChoiceQuestion("Aşağıdaki yemeklerden birini 30 gün boyunca yiyecek olsanız. Hangi yemeği tercih ederdiniz.");
            multi1.AddOption(new Option(name: "Lahmacun"));
            multi1.AddOption(new Option(name: "Mantı"));
            multi1.AddOption(new Option(name: "Adana Kebap"));
            multi1.AddOption(new Option(name: "İskender"));
            multi1.AddAnswer(new Option(name: "Lahmacun"));
            multi1.AddAnswer(new Option(name: "İskender"));
            Console.WriteLine(multi1.Answer.Name);
            Console.WriteLine(multi1.Answer.isSelected);

            var multi2 = new MultipleChoiceQuestion("Aşağıdaki şehirlerden hangisinde yaşamak isterdiniz.");
            multi2.AddOption(new Option(name: "New York"));
            multi2.AddOption(new Option(name: "London"));
            multi2.AddOption(new Option(name: "İstanbul"));
            multi2.AddOption(new Option(name: "Hong Kong"));

            var date = new DateQuestion("Doğum Tarihiniz nedir?");
            date.AddAnswer(DateTime.Now.AddYears(-23).AddDays(-4).Date);

            Console.WriteLine(date.Answer.ToString());

            var short1 = new ShortAnswerQuestion("Tuttuğunuz futbol takımının ismini giriniz.");
            short1.AddAnswer("123456789012345678901234567890");
            Console.WriteLine(short1.Answer);

            var paragraph1 = new ParagraphAnswerQuestion("Kendinizi tanıtınız.");
            paragraph1.AddAnswer("12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012567890");
            var yesno1 = new YesNoQuestion("Daha önce hiç yurtdışına çıktınız mı ?");
            yesno1.AddAnswer(true);
            Console.WriteLine(yesno1.Answer);
            yesno1.AddAnswer(false);
            Console.WriteLine(yesno1.Answer);
            var yesNo2 = new YesNoQuestion("Daha önce kan verdiniz mi ?");
            var short2 = new ShortAnswerQuestion("En sevdiğiniz yemek nedir ? ");

            //survey.AddQuestion(check1);
            //survey.AddQuestion(check2);
            //survey.AddQuestion(multi1);
            //survey.AddQuestion(multi2);
            //survey.AddQuestion(date);
            //survey.AddQuestion(short1);
            //survey.AddQuestion(short2);
            //survey.AddQuestion(paragraph1);
            //survey.AddQuestion(yesno1);
            //survey.AddQuestion(yesNo2);
            //survey.AddQuestion(yesNo2);


        }


    }
}
