using System;
using Common.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleRobot.Tests
{
    [TestClass]
    public class ConsoleMoveCalculatorTests
    {
        private ConsoleMoveCalculator _moveCalculator;

        [TestMethod]
        public void Move_North_ReturnsCorrectPosition ()
        {
            Coordinate currentPosition = new Coordinate(0, 0);
            Coordinate newPosition = _moveCalculator.Move(currentPosition, Heading.North);
            Coordinate expected = new Coordinate(0, 1);

            Assert.AreEqual(expected, newPosition);
        }

        [TestMethod]
        public void Move_South_ReturnsCorrectPosition ()
        {
            Coordinate currentPosition = new Coordinate(0, 2);
            Coordinate newPosition = _moveCalculator.Move(currentPosition, Heading.South);
            Coordinate expected = new Coordinate(0, 1);

            Assert.AreEqual(expected, newPosition);
        }

        [TestMethod]
        public void Move_East_ReturnsCorrectPosition ()
        {
            Coordinate currentPosition = new Coordinate(0, 0);
            Coordinate newPosition = _moveCalculator.Move(currentPosition, Heading.East);
            Coordinate expected = new Coordinate(1, 0);

            Assert.AreEqual(expected, newPosition);
        }

        [TestMethod]
        public void Move_West_ReturnsCorrectPosition ()
        {
            Coordinate currentPosition = new Coordinate(3, 2);
            Coordinate newPosition = _moveCalculator.Move(currentPosition, Heading.West);
            Coordinate expected = new Coordinate(2, 2);

            Assert.AreEqual(expected, newPosition);
        }

        [TestInitialize]
        public void Initialise ()
        {
            _moveCalculator = new ConsoleMoveCalculator();
        }
    }
}
