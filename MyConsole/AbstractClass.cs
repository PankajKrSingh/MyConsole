using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    abstract class AbstractClass
    {
        public abstract int Sum(int value1, int value);
        public abstract int Subtract(int value1, int value2);
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
