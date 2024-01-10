using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int result = 0;

                if (i < list1.Count && i < list2.Count)
                {
                    if (list2[i] != 0)
                    {
                        result = list1[i] / list2[i];
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                }
                else
                {
                    Console.WriteLine("Out of range");
                }

                resultList.Add(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Out of range");
            }
        }

        return resultList;
    }
}
