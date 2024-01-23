public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } }; // Return a matrix containing -1 for invalid size
        }

        int size = matrix.GetLength(0);
        double[,] rotatedMatrix = new double[size, size];

        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                double x = i - size / 2.0;
                double y = j - size / 2.0;

                int newX = (int)Math.Round(x * cosAngle - y * sinAngle + size / 2.0);
                int newY = (int)Math.Round(x * sinAngle + y * cosAngle + size / 2.0);

                if (newX >= 0 && newX < size && newY >= 0 && newY < size)
                {
                    rotatedMatrix[newX, newY] = matrix[i, j];
                }
            }
        }

        return rotatedMatrix;
    }
}
