using RotationCalculus.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Interfacess
{
    public interface IMatriz
    {
        double[,] Values { get; }
        double this[int row, int col] { get; }
        int rows { get; }
        int cols { get; }
        IVector GetUnitaryVector(int index);

    }
}
