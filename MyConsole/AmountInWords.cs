using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class AmountInWords
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> numWords = new Dictionary<int, string>();
            numWords.Add(0, "zero");
            numWords.Add(1, "one");
            numWords.Add(2, "two");
            numWords.Add(3, "three");
            numWords.Add(4, "four");
            numWords.Add(5, "five");
            numWords.Add(6, "six");
            numWords.Add(7, "seven");
            numWords.Add(8, "eight");
            numWords.Add(9, "nine");
            numWords.Add(10, "ten");
            numWords.Add(11, "eleven");
            numWords.Add(12, "twelve");
            numWords.Add(13, "thirteen");
            numWords.Add(14, "fourteen");
            numWords.Add(15, "fifteen");
            numWords.Add(16, "sixteen");
            numWords.Add(17, "seventeen");
            numWords.Add(18, "eighteen");
            numWords.Add(19, "nineteen");
            numWords.Add(20, "twenty");
            numWords.Add(30, "thirty");
            numWords.Add(40, "forty");
            numWords.Add(50, "fifty");
            numWords.Add(60, "sixty");
            numWords.Add(70, "seventy");
            numWords.Add(80, "eighty");
            numWords.Add(90, "ninety");
            numWords.Add(100, "hundred");

            List<int> data = new List<int>();
            int number = 123;
            int num = number;
            for (int i = 0; i < num.ToString().Length; i++)
            {
                data.Add(number % 10);
                number = number / 10;
            }
            foreach (int i in data)
                Console.WriteLine(numWords[i]);

            Console.ReadLine();

            
        }



    }
}
