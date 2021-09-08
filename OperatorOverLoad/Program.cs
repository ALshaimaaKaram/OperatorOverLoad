using System;

namespace OperatorOverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            #region _3DPoint
            _3DPoint p1 = new _3DPoint(2, 2, 5);
            _3DPoint p2 = new _3DPoint(2, 2, 5);

            if(p1 == p2)
              Console.WriteLine("Data Equal");
            else
              Console.WriteLine("Data Not equal");
            #endregion

            #region Fraction
            Fraction f1 = new Fraction(2, 5);
            Fraction f2 = new Fraction(1, 2);

            Fraction res = f1 + f2;

            Console.WriteLine($"The Addation is {res.numer}/{res.denom}");

            Fraction f3 = 5;
            f3.Display();

            Console.WriteLine($"The expicity is " + (double)res);

            #endregion
        }
    }
}
