using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Clases
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            if (Denominator == 1)
            {
                return Numerator.ToString();
            }
            else if (Numerator == 0)
            {
                return "0";
            }
            else
            {
                return string.Format("{0}/{1}", Numerator, Denominator);
            }
        }
    }
}
