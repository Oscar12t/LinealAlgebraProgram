
using RotationCalculus.Clases;
using RotationCalculus.Clases.Vectors;
using RotationCalculus.NewFolder;

Matriz matriz = new Matriz(new double[,] { { 2, -2 }, 
                                           { 1, 3  } });

GraphRotation rotation = new GraphRotation(matriz);

IVector currentVectorRotated = rotation.CalculateRotation(new Vector(new double[] { 1, 0 }));

currentVectorRotated.Display(DisplayOption.fraction);