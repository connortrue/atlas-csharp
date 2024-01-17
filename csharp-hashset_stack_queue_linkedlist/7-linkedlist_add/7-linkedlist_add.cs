using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        var newNode = myLList.AddFirst(n);
        return newNode;
    }
}
