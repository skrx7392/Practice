using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Ctci;

namespace Practice.Test
{
    [TestClass]
    public class StringPalindromeTest
    {
        [TestMethod]
        public void ValidCase()
        {
            var input = "abcbac";
            var stringPalindrome = new StringPalindrome();
            var result = stringPalindrome.checkPalindrome(input);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidCase2()
        {
            var input = "abcbacde";
            var stringPalindrome = new StringPalindrome();
            var result = stringPalindrome.checkPalindrome(input);
            Assert.AreEqual(false, result);
        }
    }
}
