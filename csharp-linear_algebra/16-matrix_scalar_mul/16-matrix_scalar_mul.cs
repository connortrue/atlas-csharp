public class MatrixMath {
    public static double[,] MultiplyScalar(double[,] matrix, double scalar) {
        // Check if the matrix is either 2D or 3D
        if ((matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3) || (matrix.GetLength(1) != 2 && matrix.GetLength(1) != 3)) {
            return new double[,] { { -1 } }; // Return a matrix containing -1 if the matrix is not 2D or 3D
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }
}
