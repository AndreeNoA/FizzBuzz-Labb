using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLab;
using System.IO;
using System;

namespace FizzBuzzLabTests
{
    [TestClass]
    public class LabbTests
    {
        [TestMethod]
        public void NumberTest()
        {
            //Arrange
            Program program = new Program();
            //Act
            var expected = program.printNumber(1);
            var expectedTwo = program.printNumber(4);
            var expectedThree = program.printNumber(25);
            //Assert
            Assert.AreEqual("1", expected);
            Assert.AreEqual("4", expectedTwo);
            Assert.AreNotEqual("25", expectedThree);
        }

        [TestMethod]
        public void FizzTest()
        {
            //Arrange
            Program program = new Program();
            //Act
            var expected = program.printNumber(3);
            var expectedTwo = program.printNumber(6);
            var expectedThree = program.printNumber(14);
            //Assert
            Assert.AreEqual("Fizz", expected);
            Assert.AreEqual("Fizz", expectedTwo);
            Assert.AreNotEqual("Fizz", expectedThree);
        }

        [TestMethod]
        public void BuzzTest()
        {
            //Arrange
            Program program = new Program();
            //Act
            var expected = program.printNumber(5);
            var expectedTwo = program.printNumber(10);
            var expectedThree = program.printNumber(24);
            //Assert
            Assert.AreEqual("Buzz", expected);
            Assert.AreEqual("Buzz", expectedTwo);
            Assert.AreNotEqual("Buzz", expectedThree);
        }

        [TestMethod]
        public void FizzBuzzTest()
        {
            //Arrange
            Program program = new Program();
            //Act
            var expected = program.printNumber(15);
            var expectedTwo = program.printNumber(30);
            var expectedThree = program.printNumber(42);
            //Assert
            Assert.AreEqual("Fizzbuzz", expected);
            Assert.AreEqual("Fizzbuzz", expectedTwo);
            Assert.AreNotEqual("Fizzbuzz", expectedThree);
        }

        [TestMethod]
        public void AnswerToEverythingTest()
        {
            //Arrange
            Program program = new Program();
            //Act
            var expected = program.printNumber(42);
            //Assert
            Assert.AreEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", expected);
        }

        [TestMethod]
        public void UserInputTest()
        {
            Program program = new Program();

            using (var sr = new StringReader("50"))
            {
                Console.SetIn(sr);
                Assert.AreEqual(50, program.userInput());
            }
            using (var sr = new StringReader("invalid"))
            {
                Console.SetIn(sr);
                Assert.AreEqual(0, program.userInput());
            }
        }
    }
}
