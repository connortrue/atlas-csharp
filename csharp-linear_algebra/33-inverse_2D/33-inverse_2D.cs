using System;

public class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } }; // Return [-1] if the matrix is not 2D
        }

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
        {
            return new double[,] { { -1 } }; // Return [-1] if the matrix is non-invertible
        }

        double[,] inverseMatrix = new double[2, 2];
        inverseMatrix[0, 0] = matrix[1, 1] / determinant;
        inverseMatrix[0, 1] = -matrix[0, 1] / determinant;
        inverseMatrix[1, 0] = -matrix[1, 0] / determinant;
        inverseMatrix[1, 1] = matrix[0, 0] / determinant;

        return inverseMatrix;
    }
}
