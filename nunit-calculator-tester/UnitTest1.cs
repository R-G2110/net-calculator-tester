using net_calculator_tester;
using NUnit.Framework;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [TestCase(5, 3)]
        [TestCase(10, 7)]
        [TestCase(-3, 7)]
        [TestCase(0, 0)]
        [TestCase(0.5f, 0.5f)]
        public void TestAdd(float num1, float num2)
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(num1 + num2, calculator.Add(num1, num2));
        }

        [TestCase(5, 3)]
        [TestCase(10, 7)]
        [TestCase(-3, 7)]
        [TestCase(0, 0)]
        [TestCase(0.5f, 0.2f)]
        public void TestSubtract(float num1, float num2)
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(num1 - num2, calculator.Subtract(num1, num2));
        }

        [TestCase(6, 2)]
        [TestCase(10, 5)]
        [TestCase(7, 3)]
        [TestCase(0, 5)]
        [TestCase(-10, 2)]
        [TestCase(-10, 0)]
        [TestCase(10, 0)]
        [TestCase(0, 10)]
        public void TestDivide(float num1, float num2)
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(num1 / num2, calculator.Divide(num1, num2));
        }

        [TestCase(5, 3)]
        [TestCase(10, 7)]
        [TestCase(-3, 7)]
        [TestCase(0, 0)]
        [TestCase(0.5f, 0.2f)]
        public void TestMultiply(float num1, float num2)
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(num1 * num2, calculator.Multiply(num1, num2));
        }
    }
}
