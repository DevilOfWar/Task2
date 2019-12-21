using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.Tests
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void SummTest()
        {
            Vector firstVector = new Vector(10, -4, 3);
            Vector secondVector = new Vector(4.2, 1.6, -4.35);
            Vector resultVector = firstVector + secondVector;
            Vector expectedResultVector = new Vector(14.2, -2.4, 3 - 4.35);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            firstVector = new Vector(0, 0, 0);
            resultVector = firstVector + secondVector;
            expectedResultVector = new Vector(4.2, 1.6, -4.35);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            firstVector = new Vector(3.5, -4, 17);
            secondVector = new Vector(4.2, -0.6, -84);
            resultVector = firstVector + secondVector;
            expectedResultVector = new Vector(7.7, -4.6, -67);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
        }
        [TestMethod]
        public void SubTest()
        {
            Vector firstVector = new Vector(10, -4, 3);
            Vector secondVector = new Vector(4.2, 1.6, -4.35);
            Vector resultVector = firstVector - secondVector;
            Vector expectedResultVector = new Vector(5.8, -5.6, 7.35);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            firstVector = new Vector(0, 0, 0);
            resultVector = firstVector - secondVector;
            expectedResultVector = new Vector(-4.2, -1.6, 4.35);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            firstVector = new Vector(3.5, -4, 17);
            secondVector = new Vector(4.2, -0.6, -84);
            resultVector = firstVector - secondVector;
            expectedResultVector = new Vector(3.5 - 4.2, -3.4, 101);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
        }
        [TestMethod]
        public void SkalarMultiTest()
        {
            Vector firstVector = new Vector(10, -4, 3);
            Vector secondVector = new Vector(4.2, 1.6, -4.35);
            double result = firstVector ^ secondVector;
            double expectedResult = 10 * 4.2 - 4 * 1.6 - 3 * 4.35;
            Assert.AreEqual(expectedResult, result);
            firstVector = new Vector(0, 0, 0);
            result = firstVector ^ secondVector;
            expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
            firstVector = new Vector(3.5, -4, 17);
            secondVector = new Vector(4.2, -0.6, -84);
            result = firstVector ^ secondVector;
            expectedResult = 3.5 * 4.2 + 4 * 0.6 - 84 * 17;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void MultiTest()
        {
            Vector vector = new Vector(10, -4, 3);
            double number = 4.5;
            Vector resultVector = vector * number;
            Vector expectedResultVector = new Vector(45, -18, 13.5);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            vector = new Vector(0, 0, 0);
            resultVector = vector * number;
            expectedResultVector = new Vector(0, 0, 0);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            vector = new Vector(3.5, -4, 17);
            number = -2.5;
            resultVector = vector * number;
            expectedResultVector = new Vector(-8.75, 10, -42.5);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
        }
        [TestMethod]
        public void VectorMultiTest()
        {
            Vector firstVector = new Vector(10, -4, 3);
            Vector secondVector = new Vector(4.2, 1.6, -4.35);
            Vector resultVector = firstVector * secondVector;
            Vector expectedResultVector = new Vector(-4 * (-4.35) -3 * 1.6, 56.1, 32.8);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            firstVector = new Vector(0, 0, 0);
            resultVector = firstVector * secondVector;
            expectedResultVector = new Vector(0, 0, 0);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
            firstVector = new Vector(3.5, -4, 17);
            secondVector = new Vector(4.2, -0.6, -84);
            resultVector = firstVector * secondVector;
            expectedResultVector = new Vector(346.2, 365.4, 3.5 * (-0.6) + 4 * 4.2);
            Assert.AreEqual(expectedResultVector.X, resultVector.X);
            Assert.AreEqual(expectedResultVector.Y, resultVector.Y);
            Assert.AreEqual(expectedResultVector.Z, resultVector.Z);
        }
    }
}
