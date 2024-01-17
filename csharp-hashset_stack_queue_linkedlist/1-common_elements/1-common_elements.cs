using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonElements = new List<int>();

        foreach (int item1 in list1)
        {
            foreach (int item2 in list2)
            {
                if (item1 == item2)
                {
                    commonElements.Add(item1);
                    break;
                }
            }
        }

        commonElements.Sort();
        return commonElements;
    }
}
