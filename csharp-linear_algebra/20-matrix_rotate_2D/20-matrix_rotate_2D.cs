public class MatrixMath {
    public static double[,] Rotate2D(double[,] matrix, double angle) {
        int size = matrix.GetLength(0);

        // Check if the matrix is square
        if (matrix.GetLength(0) != matrix.GetLength(1)) {
            return new double[,] { { -1 } }; // Return a matrix containing -1 if the matrix is not square
        }

        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);
        double[,] result = new double[size, size];

        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                // Apply 2D rotation transformation to each element
                double x = i - size / 2.0;
                double y = j - size / 2.0;
                double newX = x * cosAngle - y * sinAngle + size / 2.0;
                double newY = x * sinAngle + y * cosAngle + size / 2.0;

                // Interpolate the rotated value from the original matrix
                result[i, j] = Interpolate(matrix, newX, newY);
            }
        }

        return result;
    }

    private static double Interpolate(double[,] matrix, double x, double y) {
        int maxX = matrix.GetLength(0) - 1;
        int maxY = matrix.GetLength(1) - 1;

        int x0 = (int)x;
        int x1 = Math.Min(x0 + 1, maxX);
        int y0 = (int)y;
        int y1 = Math.Min(y0 + 1, maxY);

        double dx = x - x0;
        double dy = y - y0;

        double top = matrix[x0, y0] + (matrix[x1, y0] - matrix[x0, y0]) * dx;
        double bottom = matrix[x0, y1] + (matrix[x1, y1] - matrix[x0, y1]) * dx;

        return top + (bottom - top) * dy;
    }
}
