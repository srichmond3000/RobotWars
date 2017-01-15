using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utilities;
using Common.Interfaces;

namespace ConsoleRobot
{
    public class ConsolePenaltyCalculator : IPenaltyCalculator
    {
        private readonly int _arenaWidth;
        private readonly int _arenaLength;

        public ConsolePenaltyCalculator (int arenaWidth, int arenaLength)
        {
            _arenaWidth = arenaWidth;
            _arenaLength = arenaLength;
        }

        /// <summary>
        /// Calculates the penalty for a move in the specified heading from specified position.
        /// </summary>
        /// <param name="position">The current position</param>
        /// <param name="heading">The heading for the next move.</param>
        /// <returns>The penalty for the next move.</returns>
        public int CalculatePenalty (Coordinate position, Heading heading)
        {
            int penalty = 0;

            switch (heading)
            {
                case Heading.North:
                    if (OnNorthEdge(position))
                        penalty++;
                    break;

                case Heading.South:
                    if (OnSouthEdge(position))
                        penalty++;
                    break;

                case Heading.East:
                    if (OnEastEdge(position))
                        penalty++;
                    break;

                case Heading.West:
                    if (OnWestEdge(position))
                        penalty++;
                    break;

                default:
                    throw new ArgumentException("Value of heading not handled.");
            }

            return penalty;
        }

        private bool OnNorthEdge (Coordinate position) => (position.Y == _arenaLength - 1);

        private bool OnSouthEdge (Coordinate position) => (position.Y == 0);

        private bool OnEastEdge (Coordinate position) => (position.X == _arenaWidth - 1);

        private bool OnWestEdge (Coordinate position) => (position.X == 0);
    }
}
