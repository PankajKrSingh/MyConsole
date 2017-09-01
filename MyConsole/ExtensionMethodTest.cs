using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class ExtensionMethodTest
    {
        static void Main(string[] args)
        {
            string name = "Pankaj";
            Console.WriteLine(name.ChangeFirstLetterCase());
            Console.ReadLine();
        }
    }

    public static partial class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if(inputString.Length > 0)
            {
                char[] charString = inputString.ToCharArray();
                charString[0] = char.IsUpper(charString[0]) ? char.ToLower(charString[0]) : char.ToUpper(charString[0]);
                return new string(charString);
            }
            return inputString;
        }
    }
}
