
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyConsole
{
    class TestWithFile
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText( "TextFile1.txt");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
