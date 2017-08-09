using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    interface ICalculator
    {
        int Sum(int value1, int value2);
        int Subtract(int value1, int value2);
        int Multiply(int value1, int value2);
        int Divide(int value1, int value2);
    }
}
