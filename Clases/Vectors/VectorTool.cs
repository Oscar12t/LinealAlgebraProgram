using RotationCalculus.Clases.Vectors;
using RotationCalculus.Converters;
using RotationCalculus.NewFolder;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Clases
{
    public static class VectorTool
    {

        /// <summary>
        /// Add two vectors
        /// </summary>
        /// <param name="vector1">The first vector to add</param>
        /// <param name="vector2">The second vector to add</param>
        /// <returns>Returns a new vector that is the addition of the vector1 and vector2</returns>
        public static IVector Add(IVector vector1, IVector vector2)
        {
            double[] values = new double[vector1.Dimencions];

            if(vector1.Dimencions == vector2.Dimencions)
            {
                for(int i = 0; i < vector1.Dimencions; i++)
                {
                    values[i] = vector1.values[i] + vector2.values[i];
                }
            }

            return new Vector(values);
        }

        /// <summary>
        /// Subtract two vectors
        /// </summary>
        /// <param name="vector1">The first vector to Subtract</param>
        /// <param name="vector2">The second vector to Subtract</param>
        /// <returns>Returns a new vector that is the Subtraction of the vector1 and vector2</returns>
        public static IVector Subtract(IVector vector1, IVector vector2)
        {
            double[] values = new double[vector1.Dimencions];

            if (vector1.Dimencions == vector2.Dimencions)
            {
                for (int i = 0; i < vector1.Dimencions; i++)
                {
                    values[i] = vector1.values[i] - vector2.values[i];
                }
            }

            return new Vector(values);
        }

        /// <summary>
        /// It is the multiplication of a vector by an scalar
        /// To multiply a vector by a scalar we multiply each value of the vector by the scalar
        /// and the scalar can expand or contract the vector but the direcction of the vector never changes
        /// </summary>
        /// <param name="vector">The vector to be multiplied</param>
        /// <param name="expandFactor">The scalar that will be multiplied by the vector</param>
        /// <returns>Returns a new vector that is its multiplication by a scalar</returns>
        public static IVector Expand(IVector vector, double expandFactor)
        {
            double[] values = new double[vector.Dimencions];

            for (int i = 0; i < vector.Dimencions; i++)
            {
                values[i] = vector.values[i] * expandFactor;
            }

            return new Vector(values);
        }

        /// <summary>
        /// Returns in radians the angle of a vector of 2 dimencions
        /// </summary>
        /// <param name="vector">The vector that will be used</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">It needs to implement find the angle to higher dimencions</exception>
        public static double GetAngle(IVector vector)
        {
            if(vector.Dimencions == 2)
            {
                return Math.Atan(vector[1] * 1.0 / vector[0] * 1.0);
            }
            throw new NotImplementedException();
        }

        public static void Display(IVector vector, DisplayOption option)
        {
            Console.Write("[ ");

            foreach (double value in vector.values)
            {
                string currentValue = "";

                if(option == DisplayOption.decimalNumber)
                {
                    currentValue = value.ToString();
                }
                else if(option == DisplayOption.fraction)
                {

                    DecimalToFractionConverter decimalToFraction = new DecimalToFractionConverter();

                    currentValue = decimalToFraction.Convert(value).ToString();
                }

                Console.Write(currentValue);
                Console.Write(" ");
            }


            Console.Write("]");
        }

        /// <summary>
        /// Converts radians to degrees
        /// </summary>
        /// <param name="radians">the lenght in radians</param>
        /// <returns>returns the radians converted to degrees</returns>
        public static double RadiansToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        /// <summary>
        /// Converts degrees to radians
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns>The measurement of the degrees in radians</returns>
        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
    }
}
