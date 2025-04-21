using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BaseClass
    {
        private protected int privateProtectedValue { get; set; } = 0;
        internal protected int internalProtectedValue { get; set; } = 0;
    }

    class DerivedClass1 : BaseClass
    {
        BaseClass bc = new DerivedClass1();

        private int p;
        
        public DerivedClass1()
        {
            //מחלקה יורשת בתוך אותו פרויקט יכולה לגשת
            privateProtectedValue = 10;
            //אין גישה עם מצביע שלא של המחלקה שלי
            //bc.PrivateProtectedValue = 10;
            //אחרי המרה אפשר לגשת
            (bc as DerivedClass1).privateProtectedValue = 10;

            internalProtectedValue = 20;
            //אפשרי בגלל שנמצאים בתוך אותו פרויקט
            bc.internalProtectedValue = 4;
        }

        public void f(DerivedClass1 d1)
        {
            //ניתן לגשת גם דרך מופע חיצוני של המחלקה שלי, כמו לכל שדה פרטי
            d1.privateProtectedValue = 20;
            d1.p = 4;
        }
    }

    class class4
    {
        public void f()
        {
            //בתוך אותו פרויקט אפשר לגשת מכל מקום - internal
            BaseClass bc = new BaseClass();
            bc.internalProtectedValue = 5;

            DerivedClass1 d1 = new DerivedClass1();
            d1.internalProtectedValue = 9;
            //שגיאה!
            //אי אפשר לגשת ממחלקה שאינה יורשת
            //d1.privateProtectedValue = 9;
        }
    }
}
