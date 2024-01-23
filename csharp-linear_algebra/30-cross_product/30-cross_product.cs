using System;

public class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            return new double[] { -1, -1, -1 }; // Return a vector containing -1 if either vector is not a 3D vector
        }

        double[] crossProduct = new double[3];
        crossProduct[0] = Math.Round(vector1[1] * vector2[2] - vector1[2] * vector2[1], 2);
        crossProduct[1] = Math.Round(vector1[2] * vector2[0] - vector1[0] * vector2[2], 2);
        crossProduct[2] = Math.Round(vector1[0] * vector2[1] - vector1[1] * vector2[0], 2);

        return crossProduct;
    }
}
