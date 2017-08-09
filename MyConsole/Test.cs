using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public delegate void TestDelegate();
    class Test
    {
        public static void Display1()
        {
            Console.WriteLine("This is the first method");
        }

        public static void Display2()
        {
            Console.WriteLine("This is the second method");
        }

        static void Main()
        {
            TestDelegate t1 = new TestDelegate(Display1);
            TestDelegate t2 = new TestDelegate(Display2);

            t1 = t1 + t2;
            t1();
            Console.ReadLine();
        }
    }
}
