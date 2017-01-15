using System;
using Common.Interfaces;
using Common.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleRobot.Tests
{
    [TestClass]
    public class RobotWarsTests
    {
        private IMoveCalculator _moveCalculator;
        private IPenaltyCalculator _penaltyCalculator;
        private IHeadingCalculator _headingCalculator;

        [TestMethod]
        public void Scenario1_Test ()
        {
            var position = new Coordinate(0, 2);
            var robot = new ConsoleRobot(_penaltyCalculator,
                _moveCalculator,
                _headingCalculator,
                position,
                Heading.East);
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('R');

            var expectedPosition = new Coordinate(4, 1);
            var expectedHeading = Heading.North;
            var expectedPenalties = 0;

            Assert.AreEqual(expectedPosition, robot.Position, "Incorrect position");
            Assert.AreEqual(expectedHeading, robot.Heading, "Incorrect heading");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Incorrect penalties");
        }

        [TestMethod]
        public void Scenario2_Test ()
        {
            var position = new Coordinate(4, 4);
            var robot = new ConsoleRobot(_penaltyCalculator,
                _moveCalculator,
                _headingCalculator,
                position,
                Heading.South);
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('M');
            robot.SendInstruction('M');

            var expectedPosition = new Coordinate(0, 1);
            var expectedHeading = Heading.West;
            var expectedPenalties = 1;

            Assert.AreEqual(expectedPosition, robot.Position, "Incorrect position");
            Assert.AreEqual(expectedHeading, robot.Heading, "Incorrect heading");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Incorrect penalties");
        }

        [TestMethod]
        public void Scenario3_Test ()
        {
            var position = new Coordinate(2, 2);
            var robot = new ConsoleRobot(_penaltyCalculator,
                _moveCalculator,
                _headingCalculator,
                position,
                Heading.West);
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('M');
            robot.SendInstruction('R');
            robot.SendInstruction('M');

            var expectedPosition = new Coordinate(2, 2);
            var expectedHeading = Heading.North;
            var expectedPenalties = 0;

            Assert.AreEqual(expectedPosition, robot.Position, "Incorrect position");
            Assert.AreEqual(expectedHeading, robot.Heading, "Incorrect heading");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Incorrect penalties");
        }

        [TestMethod]
        public void Scenario4_Test ()
        {
            var position = new Coordinate(1, 3);
            var robot = new ConsoleRobot(_penaltyCalculator,
                _moveCalculator,
                _headingCalculator,
                position,
                Heading.North);
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('L');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('M');
            robot.SendInstruction('M');

            var expectedPosition = new Coordinate(0, 0);
            var expectedHeading = Heading.South;
            var expectedPenalties = 3;

            Assert.AreEqual(expectedPosition, robot.Position, "Incorrect position");
            Assert.AreEqual(expectedHeading, robot.Heading, "Incorrect heading");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Incorrect penalties");
        }

        [TestInitialize]
        public void Initialise ()
        {
            _moveCalculator = new ConsoleMoveCalculator();
            _penaltyCalculator = new ConsolePenaltyCalculator(5, 5);
            _headingCalculator = new ConsoleHeadingCalculator();
        }
    }
}
