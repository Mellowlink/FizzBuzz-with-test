using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz_with_Test;

namespace FizzBuzz_the_test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            FizzBuzz testFB = new FizzBuzz();

            Assert.AreEqual(testFB.PrintVal(15), "Fizz Buzz");
            Assert.AreEqual(testFB.PrintVal(30), "Fizz Buzz");
            Assert.AreEqual(testFB.PrintVal(45), "Fizz Buzz");
            Assert.AreEqual(testFB.PrintVal(60), "Fizz Buzz");
        }

        [TestMethod]
        public void TestFizz()
        {
            FizzBuzz testFB = new FizzBuzz();

            Assert.AreEqual(testFB.PrintVal(3), "Fizz");
            Assert.AreEqual(testFB.PrintVal(6), "Fizz");
            Assert.AreEqual(testFB.PrintVal(9), "Fizz");
            Assert.AreEqual(testFB.PrintVal(12), "Fizz");
        }

        [TestMethod]
        public void TestBuzz()
        {
            FizzBuzz testFB = new FizzBuzz();

            Assert.AreEqual(testFB.PrintVal(5), "Buzz");
            Assert.AreEqual(testFB.PrintVal(10), "Buzz");
            Assert.AreEqual(testFB.PrintVal(20), "Buzz");
            Assert.AreEqual(testFB.PrintVal(25), "Buzz");
        }

        [TestMethod]
        public void TestNums()
        {
            FizzBuzz testFB = new FizzBuzz();

            Assert.AreEqual(testFB.PrintVal(4), "4");
            Assert.AreEqual(testFB.PrintVal(11), "11");
            Assert.AreEqual(testFB.PrintVal(22), "22");
            Assert.AreEqual(testFB.PrintVal(31), "31");
        }
    }
}
