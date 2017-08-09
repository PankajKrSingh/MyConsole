using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            bool checkPalindrome = false;
            string name = "naman";
            char[] chrName = name.ToCharArray();
            int j = chrName.Length - 1;
            for(int i = 0; i<chrName.Length; i++)
            {
                checkPalindrome = false;
                if(chrName[i].ToString().ToLower() == chrName[j].ToString().ToLower())
                {
                    checkPalindrome = true;
                }
                j--;
            }

            if(checkPalindrome)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
