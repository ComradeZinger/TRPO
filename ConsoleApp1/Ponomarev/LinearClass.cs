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
                return x = new List<float>() { -b / a };
            }
            throw new Exception("Уравнение не существует т.к. a = 0");
        }
    }
}
