public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the matrix is square
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols)
            return new double[1, 1] { { -1 } };

        // Create a new matrix to store the result
        double[,] result = new double[rows, cols];

        // Perform the rotation operation
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * Math.Cos(angle) - matrix[j, i] * Math.Sin(angle);
            }
        }

        return result;
    }
}
