using RotationCalculus.Interfacess;
using RotationCalculus.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Clases
{
    public static class MatrizTool
    {
        /// <summary>
        /// Get the number of rows in the specified matriz
        /// </summary>
        /// <param name="matriz">the matriz to be utilized</param>
        /// <returns>the number of rows of the matriz used</returns>
        public static int RowsLenght(IMatriz matriz)
        {
            return matriz.Values.GetLength(0);
        }

        /// <summary>
        /// Get the number of cols in the specified matriz
        /// </summary>
        /// <param name="matriz">the matriz to be utilized</param>
        /// <returns>the number of cols of the matriz used</returns>
        public static int ColsLenght(IMatriz matriz)
        {
            return matriz.Values.GetLength(1);
        }

        /// <summary>
        /// Gets the data of an specified col of the matriz and converts that data to a vector
        /// </summary>
        /// <param name="index">The position of the column ex: 2</param>
        /// <param name="matriz">The matriz to be used</param>
        /// <returns>Returns a column of the matriz used as a vector</returns>
        public static IVector GetColumn(int index, IMatriz matriz)
        {
            int rows = RowsLenght(matriz);
            double[] values = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                values[i] = matriz[i, index];
            }

            return new Vector(values);
        }

        /// <summary>
        /// This method will multiply a vector by a matriz getting as an output a new vector
        /// </summary>
        /// <param name="vector">The vector that will be multiplied</param>
        /// <param name="matriz">The matriz that will multiply the vector</param>
        /// <returns>Returns a vector that is the result of the multiplication of a matriz by any specified vector</returns>
        public static IVector MultiplyMatrizByVector(IVector vector, IMatriz matriz)
        {
            IVector resultVector = new Vector(new double[] { 0, 0 });

            for(int i = 0; i < vector.Dimencions; i++)
            {
                resultVector = resultVector.Add(VectorTool.Expand(matriz.GetUnitaryVector(i), vector[i]));
            }

            return resultVector;
        }
    }
}

