using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoad
{
    class _3DPoint
    {
        private int X, Y, Z;

        public _3DPoint()
        {

        }

        public _3DPoint(int X)
        {
            this.X = X;
        }

        public _3DPoint(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public static bool operator==(_3DPoint p1, _3DPoint p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator!=(_3DPoint p1, _3DPoint p2)
        {
            return p1.X == p2.X || p1.Y == p2.Y || p1.Z == p2.Z;
        }
    }
}
