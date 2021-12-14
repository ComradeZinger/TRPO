using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponomarev;
using core;

namespace Ponomarev
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("c = ");
                int c = Convert.ToInt32(Console.ReadLine());

                PonomarevLog.I().log($"a = {a}, b = {b}, c = {c}");
                PonomarevLog.I().log($"{a}x^2 + {b}x + {c} = 0");

                QuadraticClass quadratic = new QuadraticClass();
                PonomarevLog.I().log($"Корни уравнения: {string.Join(" , ", quadratic.solve(a, b, c))}");

            }
            catch (PonomarevException ex)
            {
                PonomarevLog.I().log(ex.Message);
            }
            catch (Exception ex)
            {
                PonomarevLog.I().log(ex.Message);
            }

            PonomarevLog.I().write();

            Console.ReadKey();
        }
    }
}
