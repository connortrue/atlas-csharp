using System;
using System.Collections.Generic;

public class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int count = 0;
            foreach (int num in myList)
            {
                if (count < n)
                {
                    Console.WriteLine(num);
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
        catch (Exception)
        {
            return count;
        }
    }
}
