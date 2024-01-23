using System;

public class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 && rows != 3 && cols != 2 && cols != 3)
        {
            return -1; // Return -1 if the matrix is not 2D or 3D
        }

        if (rows == 2 && cols == 2)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
        }
        else if (rows == 3 && cols == 3)
        {
            return Math.Round(
                matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]), 2);
        }
        else
        {
            return -1; // Return -1 for any other cases
        }
    }
}
