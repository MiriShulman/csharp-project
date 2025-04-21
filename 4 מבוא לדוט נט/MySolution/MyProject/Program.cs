using cl1= MyClassLibrary;
using ClassLibrary2;
using ClassLibrary1;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cl1.Class1 c1 = new cl1.Class1();
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}