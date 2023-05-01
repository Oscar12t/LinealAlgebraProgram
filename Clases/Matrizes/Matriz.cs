using RotationCalculus.Interfacess;
using RotationCalculus.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Clases
{
    internal class Matriz : IMatriz
    {
        /// <summary>
        /// The values of the matriz
        /// </summary>
        public double[,] Values { get; }

        public double this[int row, int col] { get => Values[row, col]; }
        double IMatriz.this[int row, int col] { get => Values[row, col]; }

        /// <summary>
        /// Number of rows of the matriz
        /// </summary>
        public int rows => MatrizTool.RowsLenght(this);

        /// <summary>
        /// Numbers of cols of the matriz
        /// </summary>
        public int cols => MatrizTool.ColsLenght(this);

        

        /// <summary>
        /// A matriz that have can be access like this Values[row, colunm]
        /// </summary>
        /// <param name="matrizValues"></param>
        public Matriz(double[,] matrizValues)
        {
            Values = matrizValues;
        }

        /// <summary>
        /// Gets the unitary vector of the grapht that is represented in the matriz
        /// </summary>
        /// <param name="index">The number of unitary vector to get</param>
        /// <returns>Returns an Unitary vector type vector of the specified index</returns>
        public IVector GetUnitaryVector(int index)
        {
            return MatrizTool.GetColumn(index, this);
        }
    }
}
