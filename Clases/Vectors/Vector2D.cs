using RotationCalculus.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Clases.Vectors
{
    public class Vector2D : IVector
    {
        /// <summary>
        /// Dimencions of the vector
        /// </summary>
        public int Dimencions => 2;

        /// <summary>
        /// Coordinates of the vector (internal numbers of the vector)
        /// </summary>
        public double[] values { get; }

        public double this[int index] => values[index];

        public Vector2D(double x, double y)
        {
            values = new double[Dimencions];
        }

        /// <summary>
        /// Calculates the angle of the vector
        /// </summary>
        /// <returns>Returns the angle of the vector</returns>
        public double Angle()
        {
            return VectorTool.RadiansToDegrees(Math.Atan(values[0] * 1.0 / values[1] * 1.0));
        }

        /// <summary>
        /// Calculates the lenght of the vector
        /// </summary>
        /// <returns>Returns the lenght of the vector</returns>
        public double Lenght()
        {
            return Math.Sqrt(values[0] * values[0] + values[1] * values[1]);
        }

        public IVector Add(IVector vector)
        {
            return VectorTool.Add(this, vector);
        }

        public void Display(DisplayOption option = DisplayOption.fraction)
        {
            VectorTool.Display(this, option);
        }


    }
}
