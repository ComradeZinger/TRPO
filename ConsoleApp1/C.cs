using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class C:B
    {
        private object name3;


        public C(object one, object two, object three) : base(one,two)
        {
            this.name3 = three;
        }

    }
}
