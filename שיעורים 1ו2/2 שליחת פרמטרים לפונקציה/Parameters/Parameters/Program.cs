namespace Parameters
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 8;
            int c = Sum(ref a, b);
            Console.WriteLine(a);
            int z;
            Console.WriteLine(Sub(a, out z));
            Sum(ref z, a);

            string s = "1234";
            a = int.Parse(s);
            s = "asn";
            if (int.TryParse(s, out a))
                Console.WriteLine("Success");

            Sub(a, y: out b);
            Sub(y: out a, x: b);

            SubAbs(a, b, true);
            SubAbs(a, b, false);
            SubAbs(a, b);

            SumMulti(1, 2, new int[] { 3, 4, 5, 6 });
            SumMulti(1, 2, new int[0]);
            SumMulti(1, 2, 3, 4, 5);
            SumMulti(1, 2);
            SumMulti(1, numbers: new int[0], y: 2);

            Console.WriteLine("================");
            Class1 c1 = new Class1() { x = 12, y = 13 };
            Func(ref c1);
            Console.WriteLine(c1.x);
        }

        public static (int,string,bool) f()
        {
            return (1, "ss", true);
        }

        public static void Func(ref Class1 c)
        {
            c.x = 10;
            c.y = 20;
            c = new Class1 { x = 22, y = 33 };
        }


        public static int SumMulti(int x, int y, params int[] numbers)
        {
            int result = x + y;
            foreach (int n in numbers)
            {
                result += n;
            }
            return result;
        }

        public static int Sum(ref int x, int y)
        {
            x = 10;
            return x + y;
        }
        public static int Sub(int x, out int y)
        {
            y = 10;
            int z = x + y;
            return z;
        }
        public static double Sub(double x, out double y)
        {
            y = 10;
            double z = x + y;
            return z;
        }

        public static int SubAbs(int x1, int x2, bool abs = true)
        {
            if (abs)
                return Math.Abs(x1 - x2);
            return x1 - x2;
        }
    }
}