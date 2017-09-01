using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string word = "Hello World";
            Console.WriteLine("Original String = " + word);
            Console.WriteLine("Reverse String = " + word.ReverseString());
            Console.ReadLine();
        }
    }

    public static partial class StringHelper
    {
        public static string ReverseString(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] stringInCharArray = inputString.ToCharArray();
                StringBuilder sBuilder = new StringBuilder();
                foreach (char c in stringInCharArray)
                {
                    sBuilder.Insert(0, c);
                }

                return sBuilder.ToString();
            }
            return "";
        }
    }
}
