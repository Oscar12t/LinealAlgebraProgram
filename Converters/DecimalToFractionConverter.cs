using RotationCalculus.Clases;
using RotationCalculus.Interfacess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Converters
{
    public class DecimalToFractionConverter : IConverter<double, Fraction>
    {
        public Fraction Convert(double input)
        {
            int wholePart = (int)Math.Truncate(input);
            double decimalPart = input - wholePart;

            // Paso 1: Convertir el decimal a una fracción irreducible.
            Fraction fraction = ConvertDecimalToFraction(decimalPart);

            // Paso 2: Multiplicar el numerador de la fracción por la base elevada a la cantidad de dígitos del decimal.
            int basePower = (int)Math.Pow(10, GetDecimalPlaces(decimalPart));
            fraction = new Fraction(fraction.Numerator, fraction.Denominator * basePower);

            // Paso 3: Sumar la parte entera multiplicada por el denominador.
            fraction = new Fraction(wholePart * fraction.Denominator + fraction.Numerator, fraction.Denominator);

            return fraction;
        }

        public double Unconvert(Fraction output)
        {
            return (double)output.Numerator / output.Denominator;
        }

        private static Fraction ConvertDecimalToFraction(double decimalNumber)
        {
            int sign = Math.Sign(decimalNumber);
            decimalNumber = Math.Abs(decimalNumber);

            int wholePart = (int)Math.Truncate(decimalNumber);
            decimalNumber -= wholePart;

            int numerator = 0;
            int denominator = 1;

            // Convertir el decimal a fracción usando el algoritmo de fracciones continuas.
            while (true)
            {
                int intPart = (int)Math.Truncate(1.0 / decimalNumber);
                numerator += intPart * denominator;

                decimalNumber = 1.0 / decimalNumber - intPart;
                if (decimalNumber < double.Epsilon)
                    break;

                int temp = numerator;
                numerator = denominator;
                denominator = temp;
            }

            numerator *= sign;

            SimplifyFraction(ref numerator, ref denominator);

            return new Fraction(wholePart * denominator + numerator, denominator);
        }

        private static void SimplifyFraction(ref int numerator, ref int denominator)
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static int GetDecimalPlaces(double d)
        {
            string s = d.ToString(CultureInfo.InvariantCulture);
            int decimalIndex = s.IndexOf('.');
            if (decimalIndex < 0) return 0;
            return s.Length - decimalIndex - 1;
        }
    }
}
