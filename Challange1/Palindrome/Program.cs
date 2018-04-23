using Palindrome.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = { "racecar", "civic", "1231", "1221", "never Odd, or Even", "AbC" };
            List<bool> results = new List<bool>();

            foreach(string s in test)
            {
                results.Add(new PalindromeCheck().IsPalindrome(s));
            }

            Console.ReadKey();
        }
    }
}
