using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Recursion
    {
        int fact(int n)
        {
            int result;
            if (n == 1)
                return 1;
            result = fact(n - 1) * n;
            return result;
        }
    }

    class NewProgram
    {
        static void Main(string[] args)
        {
            Recursion obj = new Recursion();
           
        }
    }
}
