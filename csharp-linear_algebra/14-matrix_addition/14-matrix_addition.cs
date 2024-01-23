public class MatrixMath {
    public static double[,] Add(double[,] matrix1, double[,] matrix2) {
        // Check if both matrices are either 2D or 3D
        if ((matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3) || (matrix2.GetLength(0) != 2 && matrix2.GetLength(0) != 3) ||
            (matrix1.GetLength(1) != 2 && matrix1.GetLength(1) != 3) || (matrix2.GetLength(1) != 2 && matrix2.GetLength(1) != 3)) {
            return new double[,] { { -1 } }; // Return a matrix containing -1 if any matrix is not 2D or 3D
        }
        // Check if both matrices are the same size
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1)) {
            return new double[,] { { -1 } }; // Return a matrix containing -1 if both matrices are not the same size
        }

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
