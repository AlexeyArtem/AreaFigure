using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateAreaTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double s = triangle.CalculateArea();

            Assert.AreEqual(6, s);
        }

        [TestMethod]
        public void TestCalculateAreaCircle()
        {
            Circle circle = new Circle(4);

            double s = circle.CalculateArea();

            Assert.AreEqual(50, Math.Round(s));
        }

        [TestMethod]
        public void TestCheckRectangularTriangle()
        {
            Triangle triangle = new Triangle(2, 4, 5);
            Triangle rectTriangle = new Triangle(3, 4, 5);

            Assert.IsFalse(triangle.IsRectangular);
            Assert.IsTrue(rectTriangle.IsRectangular);
        }

        [TestMethod]
        public void InstanceTriangle_OneSideMoreTwoSides_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 4, 8));
        }
    }
}
