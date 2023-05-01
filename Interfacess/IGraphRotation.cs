using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.NewFolder
{
    public interface IGraphRotation
    {
        //Todo: It needs to know wich rotation it will calculate, is the rotation of the first or second unitary vector
        //It needs the param int rotationNumber
        public IVector CalculateRotation(IVector vector);
    }
}
