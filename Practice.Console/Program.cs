using System;
using Practice.Ctci;

namespace Practice.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "abcdabc";
            var stringPalindrome = new StringPalindrome();
            var result = stringPalindrome.checkPalindrome(input);
            System.Console.WriteLine(result);
        }
    }
}
