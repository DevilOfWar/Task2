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
    }
}
