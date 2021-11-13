using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Abstract
{
    public interface IAnswer<T>
    { 
        public void AddAnswer(T answer);
    }
}
