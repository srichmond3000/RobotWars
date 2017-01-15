using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utilities;

namespace Common.Interfaces
{
    public interface IHeadingCalculator
    {
        Heading Turn (char instrution, Heading currentHeading);
    }
}
