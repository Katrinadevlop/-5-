using UnitTestLada5;
using System;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void additionMethod()
        {
            int number_one = 15; 
            int number_two = 20;
            Calculator calculator = new Calculator();
            int result = calculator.addition(number_one, number_two);
            Assert.AreEqual(35, result, 1, "Ошибка при сложении");
        }

        [TestMethod]
        public void subtractionMethod()
        {
            int number_one = 14;
            int number_two = 7;
            Calculator calculator = new Calculator();
            int result = calculator.subtraction(number_one, number_two);
            Assert.AreEqual(7, result, 1, "Ошибка при вычитании");
        }

        [TestMethod]
        public void divisionMethod()
        {
            int number_one = 20;
            int number_two = 10;
            Calculator calculator = new Calculator();
            int result = calculator.division(number_one, number_two);
            Assert.AreEqual(1, result, 1, "Ошибка при делении");
        }

        [TestMethod]
        public void multiplicationMethod()
        {
            int number_one = 5;
            int number_two = 5;
            Calculator calculator = new Calculator();
            int result = calculator.multiplication(number_one, number_two);
            Assert.AreEqual(25, result, 1, "Ошибка при умножении");
        }

        [TestMethod]
        public void squaringMethod()
        {
            int number_one = 2;
            Calculator calculator = new Calculator();
            int result = calculator.squaring(number_one);
            Assert.AreEqual(4, result, 1, "Ошибка при возведении в квадрат");
        }

        [TestMethod]
        public void divisionMethodNegative()
        {
            int number_one = -15;
            int number_two = 0;
            Calculator calculator = new Calculator();
            Assert.ThrowsException<ArgumentException>(() => calculator.division(number_one, number_two));
        }

        [TestMethod]
        public void squaringMethodNegative()
        {
            int number_one = 0;
            Calculator calculator = new Calculator();
            Assert.ThrowsException<ArgumentException>(() => calculator.squaring(number_one));
        }
    }
}