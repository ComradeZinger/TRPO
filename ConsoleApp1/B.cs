using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class B:A
    {
        protected object name1;
        protected object name2;
        public B(object one, object two)
        {
            this.name1 = one;
            this.name2 = two;
        }
    }
}
