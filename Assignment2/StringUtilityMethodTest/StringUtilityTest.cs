using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using StringUtilityMethod;

namespace StringUtilityMethodTest
{
    [TestFixture]
    public class StringUtilityTest
    {
        private StringUtility str;
        [SetUp]
        public void SetUP()
        {
            str = new StringUtility();
        }

        [TestCase("Madam", "madaM")]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("hello", "olleh")]
        public void Reverse_ShouldReturnReversedString(string input, string expected)
        {
            string result = StringUtility.Reverse(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase("madam", true)]
        // [TestCase("RaceCar", true)]
        [TestCase("12321", true)]
        [TestCase("xyz", false)]

        public void ISPalindrome_ShouldReturnExpectedResult(string input, bool expected)
        {
            bool result = StringUtility.IsPalindrome(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase("hello", "HELLO")]
        [TestCase("world", "WORLD")]
        [TestCase("Test123", "TEST123")]
        [TestCase("cAsE", "CASE")]
        [TestCase("", "")]
        public void ToUpperCase_ShouldConvertToUpperCaseString(string input, string expected)
        {
            string result = StringUtility.ToUpperCase(input);
            Assert.AreEqual(expected, result);
        }
    }
}
