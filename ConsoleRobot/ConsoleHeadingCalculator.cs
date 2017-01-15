using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utilities;
using Common.Interfaces;

namespace ConsoleRobot
{
    public class ConsoleHeadingCalculator : IHeadingCalculator
    {
        /// <summary>
        /// Calculates the new heading resulting from a turn in the current heading.
        /// </summary>
        /// <param name="instruction">The turn instruction. Valid values are 'L' or 'R'.</param>
        /// <param name="currentHeading">The current heading</param>
        /// <returns>The new heading following the turn.</returns>
        public Heading Turn (char instruction, Heading currentHeading)
        {
            if (instruction != 'L' && instruction != 'R')
                throw new ArgumentException("Invalid instruction");

            Heading newHeading = Heading.North;

            switch (instruction)
            {
                case 'L':
                    newHeading = (Heading)((((int)currentHeading + 4) - 1) % 4);
                    break;

                case 'R':
                    newHeading = (Heading)(((int)currentHeading + 1) % 4);
                    break;
            }

            return newHeading;
        }


    }
}
