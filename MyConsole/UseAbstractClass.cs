using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class UseAbstractClass : AbstractClass
    {
        public override int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public override int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

      

        static void Main(string[] args)
        {
            int val1 = 10;
            int val2 = 5;

            UseAbstractClass cls = new UseAbstractClass();
            Console.WriteLine(cls.Sum(val1, val2));
            Console.WriteLine(cls.Subtract(val1, val2));
            Console.WriteLine(cls.Multiply(val1, val2));
            Console.WriteLine(cls.Divide(val1, val2));
            Console.ReadLine();
        }
    }
}
