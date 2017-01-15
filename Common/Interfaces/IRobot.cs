using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Common.Utilities;

namespace Common.Interfaces
{
    public interface IRobot
    {
        Coordinate Position { get; }
        int Penalties { get; }
        Heading Heading { get; }
        void SendInstruction (char instruction);
    }
}
