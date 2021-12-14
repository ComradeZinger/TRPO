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
            C c1 = new C(new A(), new A(), new B(new A(), new A()));
        }
    }
}
