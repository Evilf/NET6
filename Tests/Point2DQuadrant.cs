using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.BaseClasses;
using Playground.Enums;

namespace Tests
{
    [TestClass]
    public class Point2DQuadrant
    {
        [TestMethod]
        public void TetsOrigin()
        {
            XY xY = new XY(0,0);

            var quadrant = xY.GetQuadrant();

            Assert.AreEqual(Quadrant.Origin, quadrant);
        }

        [TestMethod]
        public void TetsQuadrant1()
        {
            XY xY = new XY(1, 0);

            var quadrant = xY.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant1, quadrant);
        }

        [TestMethod]
        public void TetsQuadrant2()
        {
            XY xY = new XY(-1, 1);

            var quadrant = xY.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant2, quadrant);
        }

        [TestMethod]
        public void TetsQuadrant3()
        {
            XY xY = new XY(-1, -1);

            var quadrant = xY.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant3, quadrant);
        }

        [TestMethod]
        public void TetsQuadrant4()
        {
            XY xY = new XY(1, -1);

            var quadrant = xY.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant4, quadrant);
        }
    }
}