using NUnit.Framework;
using System;
using CalculatorClass;

namespace CalculatorClass.UnitTest
{
    public class Test
    {
        public void TestAdd()
        {
            Calculator calc = new Calculator(3, 5);
            double result = calc.Add();
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Test_Subtract()
        {
            Calculator calc = new Calculator(10, 4);
            double result = calc.Subtract();
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Test_Multiply()
        {
            Calculator calc = new Calculator(6, 7);
            double result = calc.Multiply();
            Assert.AreEqual(42, result);
        }

        [Test]
        public void Test_Divide_Valid()
        {
            Calculator calc = new Calculator(20, 5);
            double result = calc.Divide();
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_Divide_ByZero()
        {
            Calculator calc = new Calculator(10, 0);
            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }

    } 
}
    