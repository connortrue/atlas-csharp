using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        var node = myLList.First;

        while (node != null)
        {
            count++;
            node = node.Next;
        }

        return count;
    }
}
