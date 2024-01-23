using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the matrix is a square
        int n = matrix.GetLength(0);
        if (n != matrix.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        // Create a new matrix for the result
        double[,] result = new double[n, n];

        // Apply the rotation operation to each element
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double x = i - n / 2.0;
                double y = j - n / 2.0;

                // Calculate the new element after rotation
                double newElement = Math.Cos(angle) * matrix[i, j] + Math.Sin(angle) * (x * matrix[i, j] - y);
                
                // Round the result to 2 decimal places
                result[i, j] = Math.Round(newElement, 2);
            }
        }

        return result;
    }
}
