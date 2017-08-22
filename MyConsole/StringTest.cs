using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class StringTest
    {
        public int ID { get; set; }

        static void Main(string[] args)
        {
            string s = "abc";
            StringTest obj = new StringTest();
            obj.ID = 10;
            Method1(obj);
            Method1(s);

       

            Console.WriteLine(s);
            Console.WriteLine(obj.ID);
            Console.ReadLine();
        }

        private static void Method1(StringTest obj)
        {
            obj.ID = 20;
        }

        private static void Method1(string s)
        {
            s = "def";
        }


    }

    class Test1
    {
       
    }
}
