using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentElements = new List<int>();

        foreach (int item1 in list1)
        {
            if (!list2.Contains(item1))
            {
                differentElements.Add(item1);
            }
        }

        foreach (int item2 in list2)
        {
            if (!list1.Contains(item2))
            {
                differentElements.Add(item2);
            }
        }

        differentElements.Sort();
        return differentElements;
    }
}
