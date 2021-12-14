using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class B:A
    {
        private List<double> xRes;
        public List<double> quadraticEquation(double a, double b, double c)
        {
            
            if (a == 0)
            {
                return linearEquation(b, c);
            }
            double Dis = discriminant(a, b, c);
            if (Dis == 0)
            {
                return xRes = new List<double>() { -b / 2 * a };
            }

            if (Dis < 0)
            {
                throw new Exception("Dis < 0");
            }

            return xRes = new List<double>() { (-b + Math.Sqrt(Dis)) / (2 * a) , (-b - Math.Sqrt(Dis)) / (2 * a) };
        }
        private double discriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
