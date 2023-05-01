using RotationCalculus.Clases.Vectors;
using RotationCalculus.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Clases
{
    public class Vector : IVector
    {
        /// <summary>
        /// The dimecions of the vector
        /// </summary>
        public int Dimencions { get; }

        /// <summary>
        /// Coordinates of the vector (the internal numbers of a vector)
        /// </summary>
        public double[] values { get; }

        /// <summary>
        /// The coordinates of the vector
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Returns the coordinate of a vector in a specified index</returns>
        public double this[int index] => values[index];

        public Vector(double[] values)
        {
            this.Dimencions = values.Length;
            this.values = values;
        }


        public IVector Add(IVector vector)
        {
            return VectorTool.Add(this, vector);
        }

        public double Angle()
        {
            return VectorTool.GetAngle(this);
            //Todo: Aprender Producto punto
        }

        /// <summary>
        /// The lenght that the vector have in the graph
        /// </summary>
        /// <returns>How long the vector is</returns>
        public double Lenght()
        {
            double currentLenght = 0;

            for(int i = 0; i < Dimencions; i++)
            {
                currentLenght += Math.Pow(values[i], 2);
            }

            currentLenght = Math.Sqrt(currentLenght);
            return currentLenght;
        }


        public void Display(DisplayOption option)
        {
            VectorTool.Display(this, option);
        }
    }
}
