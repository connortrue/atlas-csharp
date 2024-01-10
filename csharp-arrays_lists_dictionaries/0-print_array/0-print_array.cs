using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        else
        {
        for (i = 0; i < array.Length; i++)
        {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(" ");
        }
            Console.WriteLine();
            return newArray;
        }
    }

    public static void PrintArray(int size)
    {
        CreatePrint(size);
    }
}
