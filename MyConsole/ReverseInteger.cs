using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class ReverseInteger
    {
        static void Main(string[] args)
        {
            int value = 2324;
            ReverseValue(value);
        }

        private static void ReverseValue(int value)
        {
            int newValue = 0;
            while(value % 10 != 0)
            {
                //if (newValue == null)
                //{
                //    newValue = value % 10;
                //}
                //else
                //{
                    newValue = (newValue * 10) + (value % 10);
                //}

                value = value / 10;
            }
            Console.WriteLine(newValue);
            Console.ReadLine();
        }
    }
}
