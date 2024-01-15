using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> newList = new List<int>();
        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i);
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return newList;
    }
}
