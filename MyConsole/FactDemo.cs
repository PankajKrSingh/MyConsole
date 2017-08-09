using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class FactDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
            Console.ReadLine();
        }

        private static int Fact(int num)
        {
            if (num == 0)
                return 1;

            return Fact(num - 1) * num;

        }
    }
}
