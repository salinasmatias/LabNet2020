using System;
using ExceptionsLibrary;
using LabNet2020;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class ExceptionsAndLogicTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AttemptToDivideByZeroTest()
        {
            // Arrange
            ExceptionsPractice testInstance = new ExceptionsPractice();

            // Act
            testInstance.AttemptToDivideByZero(2);
        }

        [TestMethod()]
        public void IntegerDivisionTest()
        {
            // Arrange
            ExceptionsPractice testInstance = new ExceptionsPractice();
            int expected = 5, numerator = 20, denominator = 4;


            // Act
            int actual = testInstance.IntegerDivision(numerator, denominator);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ILoveThrowingCustomExceptionsTest()
        {
            // Arrange
            Logic testInstance = new Logic();

            // Act
            testInstance.ILoveThrowingCustomExceptions();
        }
    }
}
