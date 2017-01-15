using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utilities;
using Common.Interfaces;

namespace ConsoleRobot
{
    public class ConsoleMoveCalculator : IMoveCalculator
    {
        /// <summary>
        /// Calculates the result of a move from the current position in the specified heading.
        /// </summary>
        /// <param name="currentPosition">The current position.</param>
        /// <param name="heading">The heading to move in.</param>
        /// <returns>The new position following moving from the specified position in the specified heading.</returns>
        public Coordinate Move (Coordinate currentPosition, Heading heading)
        {
            Coordinate newPosition = null;

            switch (heading)
            {
                case Heading.North:
                    newPosition = new Coordinate(currentPosition.X, currentPosition.Y + 1);
                    break;

                case Heading.South:
                    newPosition = new Coordinate(currentPosition.X, currentPosition.Y - 1);
                    break;

                case Heading.East:
                    newPosition = new Coordinate(currentPosition.X + 1, currentPosition.Y);
                    break;

                case Heading.West:
                    newPosition = new Coordinate(currentPosition.X - 1, currentPosition.Y);
                    break;

                default:
                    throw new ArgumentException("Value of heading not handled.");
            }

            return newPosition;
        }
    }
}
