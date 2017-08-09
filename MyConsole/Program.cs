using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass1 = new MyClass<int>();
            Console.WriteLine(myClass1.CompareMe(1, 1));

            MyClass<string> myClass2 = new MyClass<string>();
            Console.WriteLine(myClass2.CompareMe("hello", "Hello"));

            Console.ReadLine();
        }
    }

    public class MyClass<DataType>
    {
        public bool CompareMe(DataType param1, DataType param2)
        {
            return param1.Equals(param2) ? true : false;
        }

        
    }


}
