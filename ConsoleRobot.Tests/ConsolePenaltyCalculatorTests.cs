using System;
using System.Security.Cryptography;
using Common.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleRobot.Tests
{
    [TestClass]
    public class ConsolePenaltyCalculatorTests
    {
        private ConsolePenaltyCalculator _penaltyCalculator;
        private const int ARENA_WIDTH = 5;
        private const int ARENA_LENGTH = 5;

        [TestMethod]
        public void CalculatePenalty_InMiddleHeadingNorth_ReturnsZero ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(2, 2), Heading.North);
            int expected = 0;

            Assert.AreEqual(expected, penalty);
        }

        [TestMethod]
        public void CalculatePenalty_InMiddleHeadingSouth_ReturnsZero ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(2, 2), Heading.South);
            int expected = 0;

            Assert.AreEqual(expected, penalty);
        }

        [TestMethod]
        public void CalculatePenalty_InMiddleHeadingEast_ReturnsZero ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(2, 2), Heading.East);
            int expected = 0;

            Assert.AreEqual(expected, penalty);
        }

        [TestMethod]
        public void CalculatePenalty_InMiddleHeadingWest_ReturnsZero ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(2, 2), Heading.West);
            int expected = 0;

            Assert.AreEqual(expected, penalty);
        }

        [TestMethod]
        public void CalculatePenalty_OnNorthEdgeHeadingNorth_ReturnsOne ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(2, ARENA_LENGTH - 1), Heading.North);
            int expected = 1;

            Assert.AreEqual(expected, penalty);
        }

        [TestMethod]
        public void CalculatePenalty_OnSouthEdgeHeadingSouth_ReturnsOne ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(2, 0), Heading.South);
            int expected = 1;

            Assert.AreEqual(expected, penalty);
        }

        [TestMethod]
        public void CalculatePenalty_OnEastEdgeHeadingEast_ReturnsOne ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(ARENA_WIDTH - 1, 2), Heading.East);
            int expected = 1;

            Assert.AreEqual(expected, penalty);
        }

        [TestMethod]
        public void CalculatePenalty_OnWestEdgeHeadingWest_ReturnsOne ()
        {
            int penalty = _penaltyCalculator.CalculatePenalty(new Coordinate(0, 2), Heading.West);
            int expected = 1;

            Assert.AreEqual(expected, penalty);
        }

        [TestInitialize]
        public void Initialise ()
        {
            _penaltyCalculator = new ConsolePenaltyCalculator(ARENA_WIDTH, ARENA_LENGTH);
        }
    }
}
