using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.BL;

namespace PalindromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void TestIsPalindrome()
        {
            //Arrange
            List<bool> results = new List<bool>();
            string[] test = { "racecar", "civic", "1231", "1221", "never Odd, or Even", "AbC" };
            List<bool> expectedResults = new List<bool> { true, true, false, true, true, false };
            //Act
            foreach(string s in test)
            {
                results.Add(new PalindromeCheck().IsPalindrome(s));
            }
            //Assert
            for(int i = 0; i < results.Count; i++)
            {
                Assert.AreEqual(expectedResults[i], results[i]);
            }
        }
    }
}
