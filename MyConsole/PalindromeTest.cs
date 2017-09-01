using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class PalindromeTest
    {
        static void Main(string[] args)
        {
            string s = "xxbiclrqlljiqekdqthzvmrsewaaymqg";
            string s1 = "apple";

            Console.WriteLine(numberOfPalindromes(32, s));
            Console.ReadLine();
        }

        static int numberOfPalindromes(int input1, string input2)
        {
            char[] c = input2.ToCharArray();
            int count = 0;
            List<string> lst = new List<string>();

            for (int i = 0; i < input1; i++)
            {
                string str = c[i].ToString();
                if (lst.Contains(str) && c[i - 1] == c[i])
                {
                    str = str + str;
                }
                if (!lst.Contains(str))
                {
                    lst.Add(str);
                    count++;
                }
            }
            return count;
        }

    }
}
