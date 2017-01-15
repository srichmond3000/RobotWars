using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utilities;
using Common.Interfaces;

namespace ConsoleRobot
{
    public class ConsoleRobot : IRobot
    {
        private readonly IPenaltyCalculator _penaltyCalculator;
        private readonly IMoveCalculator _moveCalculator;
        private readonly IHeadingCalculator _headingCalculator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="penaltyCalculator">The penalty calculator</param>
        /// <param name="moveCalculator">The move calculator.</param>
        /// <param name="headingCalculator">The heading calculator.</param>
        /// <param name="position">The start position of the robot.</param>
        /// <param name="heading">The start heading of the robot.</param>
        public ConsoleRobot (IPenaltyCalculator penaltyCalculator,
            IMoveCalculator moveCalculator,
            IHeadingCalculator headingCalculator,
            Coordinate position,
            Heading heading)
        {
            _penaltyCalculator = penaltyCalculator;
            _moveCalculator = moveCalculator;
            _headingCalculator = headingCalculator;
            Heading = heading;
            Position = position;
        }

        /// <summary>
        /// Gets the position of the robot.
        /// </summary>
        public Coordinate Position { get; private set; }

        /// <summary>
        /// Gets the number of penalties accrued by the robot.
        /// </summary>
        public int Penalties { get; private set; }

        /// <summary>
        /// Gets the heading of the robot.
        /// </summary>
        public Heading Heading { get; private set; }

        /// <summary>
        /// Sends an instruction to the robot that may affect it's heading, position or penalities.
        /// </summary>
        /// <param name="instruction">Valid values are 'M' to move, 'L' to turn left or 'R' to turn right.</param>
        public void SendInstruction (char instruction)
        {
            if (instruction != 'L' && instruction != 'R' && instruction != 'M')
                throw new ArgumentException("Invalid instruction");

            switch (instruction)
            {
                case 'L':
                    Heading = _headingCalculator.Turn(instruction, Heading);
                    break;

                case 'R':
                    Heading = _headingCalculator.Turn(instruction, Heading);
                    break;

                case 'M':
                    Move();
                    break;
            }
        }

        private void Move ()
        {
            var penalties = _penaltyCalculator.CalculatePenalty(Position, Heading);

            if (penalties == 0)
            {
                Position = _moveCalculator.Move(Position, Heading);
            }
            else
            {
                Penalties += penalties;
            }
        }
    }
}
