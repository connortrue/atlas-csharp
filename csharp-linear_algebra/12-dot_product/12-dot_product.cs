public class VectorMath {
    public static double DotProduct(double[] vector1, double[] vector2) {
        // Check if both vectors are either 2D or 3D
        if ((vector1.length != 2 && vector1.length != 3) || (vector2.length != 2 && vector2.length != 3)) {
            return -1; // Return -1 if any vector is not 2D or 3D
        }
        // Check if both vectors are the same size
        if (vector1.length != vector2.length) {
            return -1; // Return -1 if both vectors are not the same size
        }

        double dotProduct = 0;
        for (int i = 0; i < vector1.length; i++) {
            dotProduct += vector1[i] * vector2[i];
        }
        return dotProduct;
    }
}
