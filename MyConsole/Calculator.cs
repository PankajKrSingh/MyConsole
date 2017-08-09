using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Calculator : ICalculator
    {
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int val1 = 10;
            int val2 = 5;
            Console.WriteLine(calculator.Sum(val1, val2));
            Console.WriteLine(calculator.Subtract(val1, val2));
            Console.WriteLine(calculator.Multiply(val1, val2));
            Console.WriteLine(calculator.Divide(val1, val2));
            Console.ReadLine();

        }
    }

    
}
