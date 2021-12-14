using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        protected List<double> x;
        public List<double> linearEquation(double a, double b)
        { 
            if (a != 0)
            {
                return x = new List<double>() { -b / a };
            }
            throw new Exception("Уравнение не существует");
        }
    }
}
