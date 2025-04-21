using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndRecord
{
    internal struct MyStruct
    {
        public int MyProperty { get; set; }
        public string s { get; set; }

        //בנאי של מבנה חייב לתת ערכים לכל השדות
        public MyStruct()
        {
            MyProperty = 0;
            s = "";
        }

        //בנאי של מבנה חייב לתת ערכים לכל השדות
        public MyStruct(int x, string y)
        {
            MyProperty = x;
            s = y;
        }
    }
}
