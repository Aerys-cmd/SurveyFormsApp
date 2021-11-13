using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Abstract
{
    interface IMultipleAnswer<T>
    {
        public void AddAnswer(T answer);

    }
}
