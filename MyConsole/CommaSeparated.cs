using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class CommaSeparated
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>() { "India", "UK", "USA", "Germany" };
            Console.WriteLine(lst.Aggregate((a, b) => a + ", " + b));
            Console.ReadLine();
        }

        
        
    }
}
