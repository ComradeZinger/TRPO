using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                B b = new B();
                List<double> xList = b.quadraticEquation(0, 0, 15);
                if (xList.Count != 0)
                {
                    for (int i = 0; i < xList.Count; i++)
                    {
                        Console.WriteLine(xList.ElementAt(i).ToString());
                    }
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Уровнение не имеет корней или не существует: " + ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
