using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoad
{
    class Fraction
    {
        public double numer;
        public double denom;

        //Constructor
        public Fraction()
        {

        }

        public Fraction(double numer)
        {
            this.numer = numer;
        }

        public Fraction(double numer, double denom)
        {
            this.numer = numer;
            if (denom > 0)
                this.denom = denom;
            else
                this.denom = 1;
        }

        public void Display()
        {
            Console.WriteLine($"The Fraction is {numer} / {denom}");
        }

        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.numer = f1.numer * f2.denom + f2.numer * f1.denom;
            res.denom = f1.denom * f2.denom;
            return res;
        }

        public static implicit operator Fraction(int x)
        {
            return new Fraction(x, 1); ;
        }

        public static explicit operator double(Fraction f)
        {
            return f.numer/f.denom;
        }
    }
}
