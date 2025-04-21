namespace StructAndRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct s; //הוקצה זיכרון עבור מופע של המבנה
            MyClass c;//הוקצה מצביע

            //שיגאה - השדות עדיין לא מאותחלים
            //s.MyProperty = 9;

            c = new MyClass(4, 5); //הוקצה זיכרון ואותחל בערכי ברירת מחדל
            s = new MyStruct(); //אתחול השדות בערכי ברירת מחדל
            c = new MyClass(7, 8); //הוקצה זיכרון חדש
            s.MyProperty = 90;
            s = new MyStruct(); //אתחול השדות בערכי ברירת מחדל באותו מקום בזיכרון

            MyStruct s2 = s; //העתקה רדודה של השדות
            MyStruct s3 = new MyStruct();
            s.MyProperty = 1;
            s.s = "st";
            s3.MyProperty = 1;
            s3.s = "st";
            Console.WriteLine(s.Equals(s3));//true
            MyClass c2 = c;

            MyStruct2 st2;
            //החל מגירסה 7 של דוט נט ניתן לאתחל מבנה עם תכונה אחת בצורה כזו ללא זימון בנאי
            //st2.a = 7;

            //הבנאי עם הפרמטרים לא דורס את הבנאי ברירת מחדל
            MyStruct2 st3 = new MyStruct2();

            string str = "abc";
            string str2 = "abc";
            Console.WriteLine(str == str2);//true
            str = str2;
            str2 = "cc";
            Console.WriteLine(str[2]);//c
            //str[2] = 'd'; שגיאה! אי אפשר לשנות מחרוזת
            Console.WriteLine($"str={str}, str2={str2}");

            Console.WriteLine("==============================");
            Student stu1 = new Student(123, "Sari", 95) { Name = "Sara" };
            //stu1.Name = "Sara"; השדות מוגדרים כ init
            stu1.MyProperty = 100;
            Student stu2 = new Student();
            Console.WriteLine(stu1);
            Console.WriteLine(stu2);

            stu2 = stu1;//מעתיק כתובות
            stu2 = stu1 with {Name="Shoshi" };//יוצר מופע חדש עם ערכי שדות זהים
            Console.WriteLine(stu2);

            int x = 9;
            int? y = x;
            x = y ?? 100;
            x = y ?? throw new Exception("Error");

            f(null);
        }

        public static void f(Student? s)
        {
            Console.WriteLine(s?.Id);
            Console.WriteLine(s!.Name);
        }
    }
}