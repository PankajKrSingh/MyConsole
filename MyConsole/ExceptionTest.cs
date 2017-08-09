using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class ExceptionTest
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 100;
                int den = 0;
                try
                {
                    Console.WriteLine("Message 1");
                    int res = num / den;
                    Console.WriteLine("Message 2");
                }
                catch(ArithmeticException)
                {
                    Console.WriteLine("Message 3");
                }
            }
            catch(Exception)
            { }
            finally
            {
                Console.WriteLine("Message 4");
            }
        }

    }
}
