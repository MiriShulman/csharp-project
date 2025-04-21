using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndRecord
{
    internal record Student
        (int Id,
        string Name,
        double? Mark = null)
    {
        public int MyProperty { get; set; }

        public Student() : this(0, "", null)
        {
            Id = 111;
        }
    }
}
