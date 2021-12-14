using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponomarev
{
    class LinearClass
    {
        protected List<float> x;
        public List<float> linearEquation(float a, float b)
        { 
            if (a != 0)
            {
                PonomarevLog.I().log("Это линейное уравнение");
                return x = new List<float>() { -b / a };
            }
            throw new PonomarevException("ОШИБКА: Уравнение не существует т.к. a = 0");
        }
    }
}
