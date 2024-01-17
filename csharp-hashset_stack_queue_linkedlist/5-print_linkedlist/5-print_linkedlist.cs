using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list = new LinkedList<int>();

        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                list.AddLast(i);
                Console.WriteLine(i);
            }
        }

        return list;
    }
}
