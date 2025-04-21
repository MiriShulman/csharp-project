using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace MyProject
{
    internal class DerivedClass2 : BaseClass
    {
        BaseClass bc = new DerivedClass2();
        DerivedClass2 d2 = new DerivedClass2();
        public DerivedClass2()
        {
            //שגיאה!
            //מחלקה יורשת בפרויקט אחר לא יכולה לגשת
            //PrivateProtectedValue = 10;
            //ממחלקה יורשת ניתן לגשת גם אם זה בפרויקט אחר
            internalProtectedValue = 8;
            //שגיאה!
            //ממחלקה יורשת בפרויקט אחר ניתן לגשת רק דרך מצביע של המחלקה שלי
            //bc.internalProtectedValue = 8;
            //אחרי המרה אפשר
            (bc as DerivedClass2).internalProtectedValue = 8;
            //דרך מצביע של המחלקה שלי ניתן לגשת גם אם זה מופע חיצוני
            d2.internalProtectedValue = 7;
        }
    }
}
