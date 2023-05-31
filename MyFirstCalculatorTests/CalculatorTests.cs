using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [TestMethod()]
        public void SumTest()
        {
            Assert.IsTrue(calculator.Sum(2, 2) == 4);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.IsTrue(calculator.Subtract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(calculator.Multiply(2, 2) == 4);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsTrue(calculator.Divide(10, 5) == 2);
        }
    }
}