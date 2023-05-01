using RotationCalculus.Clases.Vectors;
using RotationCalculus.Interfacess;
using RotationCalculus.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Clases
{
    public class GraphRotation : IGraphRotation
    {
        private IMatriz matriz;

        public GraphRotation(IMatriz matriz)
        {
            this.matriz = matriz;
        }

        public IVector CalculateRotation(IVector vector)
        {
            IVector vectorTransformed = GetVectorTransformed(vector);

            //Code for Second unitary vector
            IVector secondUnitaryVector = matriz.GetUnitaryVector(1);

            double routeDistance = secondUnitaryVector.Angle();
            routeDistance = Math.Tan(routeDistance) * 1.0;
            routeDistance = Math.Abs(vectorTransformed[1] * 1.0 / routeDistance);


            double firstValue = vectorTransformed[0] + routeDistance;
            double secondValue = -routeDistance/secondUnitaryVector[0];

            return new Vector(new double[] { firstValue, secondValue });

        }

        private IVector GetVectorTransformed(IVector vector)
        {
            return MatrizTool.MultiplyMatrizByVector(vector, matriz);
        }
    }
}
