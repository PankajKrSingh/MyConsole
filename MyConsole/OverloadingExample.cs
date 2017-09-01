using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class OverloadingExample
    {
        static void Main(string[] args)
        {

        }


        public void Sum(int value1, long value2)
        {
            Console.WriteLine("Sum of " + value1 + " & " + value2 + " = " + (value1 + value2));
        }

        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
