public class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } }; // Return a matrix containing -1 for invalid size
        }

        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } }; // Return a matrix containing -1 for invalid direction
        }

        int size = matrix.GetLength(0);
        double[,] shearedMatrix = new double[size, size];

        if (direction == 'x')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    shearedMatrix[i, j] = matrix[i, j + (int)(factor * i)];
                }
            }
        }
        else if (direction == 'y')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    shearedMatrix[i, j] = matrix[i + (int)(factor * j), j];
                }
            }
        }

        return shearedMatrix;
    }
}
