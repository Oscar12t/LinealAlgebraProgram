using RotationCalculus.Clases.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.NewFolder
{
    public interface IVector
    {
        int Dimencions { get; }
        double[] values { get; }
        double this[int index] { get; }

        IVector Add(IVector vector);
        double Lenght();
        double Angle();


        void Display(DisplayOption option);

    }
}
