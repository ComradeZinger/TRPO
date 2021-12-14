using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Ponomarev
{
    class QuadraticClass:LinearClass, EquationInterface
    {
        private List<float> xRes;
        public List<float> solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return linearEquation(b, c);
            }
            float Dis = discriminant(a, b, c);
            PonomarevLog.I().log("Это квадратное уравнение");
            if (Dis == 0)
            {
                return xRes = new List<float>() { -b / 2 * a };
            }

            if (Dis < 0)
            {
                throw new PonomarevException("ОШИБКА: Dis < 0");
            }

            return xRes = new List<float>() { (-b + (float)Math.Sqrt(Dis)) / (2 * a) , (-b - (float)Math.Sqrt(Dis)) / (2 * a) };
        }
        private float discriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
