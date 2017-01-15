using System;
using Common.Interfaces;
using Common.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleRobot.Tests
{
    [TestClass]
    public class ConsoleHeadingCalculatorTests
    {
        private ConsoleHeadingCalculator _headingCalculator;

        [TestMethod]
        public void Turn_CurrentHeadingNorthToRight_ReturnsEast ()
        {
            Heading newHeading = _headingCalculator.Turn('R', Heading.North);
            Heading expected = Heading.East;

            Assert.AreEqual(expected, newHeading);
        }

        [TestMethod]
        public void Turn_CurrentHeadingEastToRight_ReturnsSouth ()
        {
            Heading newHeading = _headingCalculator.Turn('R', Heading.East);
            Heading expected = Heading.South;

            Assert.AreEqual(expected, newHeading);
        }

        [TestMethod]
        public void Turn_CurrentHeadingSouthToRight_ReturnsWest ()
        {
            Heading newHeading = _headingCalculator.Turn('R', Heading.South);
            Heading expected = Heading.West;

            Assert.AreEqual(expected, newHeading);
        }

        [TestMethod]
        public void Turn_CurrentHeadingWestToRight_ReturnsNorth ()
        {
            Heading newHeading = _headingCalculator.Turn('R', Heading.West);
            Heading expected = Heading.North;

            Assert.AreEqual(expected, newHeading);
        }

        [TestMethod]
        public void Turn_CurrentHeadingNorthToLeft_ReturnsWest ()
        {
            Heading newHeading = _headingCalculator.Turn('L', Heading.North);
            Heading expected = Heading.West;

            Assert.AreEqual(expected, newHeading);
        }

        [TestMethod]
        public void Turn_CurrentHeadingEastToLeft_ReturnsNorth ()
        {
            Heading newHeading = _headingCalculator.Turn('L', Heading.East);
            Heading expected = Heading.North;

            Assert.AreEqual(expected, newHeading);
        }

        [TestMethod]
        public void Turn_CurrentHeadingSouthToLeft_ReturnsEast ()
        {
            Heading newHeading = _headingCalculator.Turn('L', Heading.South);
            Heading expected = Heading.East;

            Assert.AreEqual(expected, newHeading);
        }

        [TestMethod]
        public void Turn_CurrentHeadingWestToLeft_ReturnsSouth ()
        {
            Heading newHeading = _headingCalculator.Turn('L', Heading.West);
            Heading expected = Heading.South;

            Assert.AreEqual(expected, newHeading);
        }

        [TestInitialize]
        public void Initialise ()
        {
            _headingCalculator = new ConsoleHeadingCalculator();
        }
    }
}
