using System;
using NUnit.Framework;
using NumberSystem;

namespace NumberTest
{
    [TestFixture]
    public class NumberTests
    {
        [TestCase(16, "EVEN")]
        [TestCase(18, "EVEN")]
        [TestCase(15, "ODD")]
        [TestCase(15, "EVEN")]
        public void TestEvenNumberReturnsEven(int num, string expected)
        {

            Number n1 = new Number(num);
            string actual = n1.EvenAndOdd();
            //Assert.That(actual, Is.EqualTo(expected));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2, "ODD")]
        [TestCase(9, "EVEN")]
        [TestCase(13, "ODD")]
        [TestCase(999, "ODD")]
        public void TestOddNumberReturnsOdd(int num, string expected)
        {
         
            Number n1 = new Number(num);
            string actual = n1.EvenAndOdd();
            Assert.AreEqual(expected, actual);
        }
    }
}
