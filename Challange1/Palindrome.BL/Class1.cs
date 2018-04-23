using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindrome.BL
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string test)
        {
            test = Regex.Replace(test, @"(\s+|@|&|'|\(|\)|<|>|#|,)", "");
            test = test.ToLower();
            int min = 0;
            int max = test.Length - 1;
            if (min > max)
            {
                return true;
            }
            while (min < max)
            {
                char a = test[min];
                char b = test[max];
                if (!a.Equals(b))
                {
                    Console.WriteLine($"{test} Is not a Palindrome");
                    return false;
                }
                min++;
                max--;
            }
            Console.WriteLine($"{test} Is a Palindrome");
            return true;
        }
    }
}
