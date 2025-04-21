using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndRecord
{
    internal class MyClass
    {
        public int x { get; set; }
        public int y { get; set; }

        public MyClass(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        //פונקציה הורסת
        ~MyClass()
        {

        }
    }
}
