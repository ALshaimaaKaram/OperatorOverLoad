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

        public static _3DPoint operator ++(_3DPoint p)
        {
            return new _3DPoint(p.X + 1, p.Y + 1, p.Z + 1);
        }

        public static bool operator &(_3DPoint p1, _3DPoint p2)
        {
            bool p1flag = !((p1.X == 0) && (p1.Y == 0) && (p1.Z== 0));
            bool p2flag = !((p2.X == 0) && (p2.Y == 0) && (p1.Z == 0));

            return p1flag & p2flag;
        }

        public static bool operator |(_3DPoint p1, _3DPoint p2)
        {
            bool p1flag = !((p1.X == 0) && (p1.Y == 0) && (p1.Z == 0));
            bool p2flag = !((p2.X == 0) && (p2.Y == 0) && (p1.Z == 0));

            return p1flag | p2flag;
        }

        public static bool operator ^(_3DPoint p1, _3DPoint p2)
        {
            bool p1flag = !((p1.X == 0) && (p1.Y == 0) && (p1.Z == 0));
            bool p2flag = !((p2.X == 0) && (p2.Y == 0) && (p1.Z == 0));

            return p1flag ^ p2flag;
        }


        public override string ToString()
        {
            return $"X is {X}, Y is {Y}, Z is {Z}";
        }
    }
}
