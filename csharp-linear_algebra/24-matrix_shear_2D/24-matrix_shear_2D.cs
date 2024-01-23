public class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check if the matrix is square
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != cols)
            return new double[1, 1] { { -1 } };

        // Check if the direction is valid
        if (direction != 'x' && direction != 'y')
            return new double[1, 1] { { -1 } };

        // Create a new matrix to store the result
        double[,] result = new double[rows, cols];

        // Perform the shear operation
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (direction == 'x')
                    result[i, j] = matrix[i, j] + factor * j;
                else
                    result[i, j] = matrix[i, j] + factor * i;
            }
        }

        return result;
    }
}
