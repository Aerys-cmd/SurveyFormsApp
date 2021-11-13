using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class Option
    {
        public Option(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public bool isSelected { get; set; } = false;
    }
}
