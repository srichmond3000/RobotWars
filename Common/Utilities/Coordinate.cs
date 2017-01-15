using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public class Coordinate
    {
        public Coordinate (int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public override bool Equals (object obj)
        {
            Coordinate other = obj as Coordinate;

            if (other == null)
                return false;

            return (X == other.X) && (Y == other.Y);
        }

        public override int GetHashCode ()
        {
            int hash = 3 * X.GetHashCode();
            hash += 5 * Y.GetHashCode();

            return hash;
        }
    }
}
