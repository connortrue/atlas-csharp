using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in aQueue
        Console.WriteLine("Number of items: " + aQueue.Count);

        // Print the item at the top of aQueue without removing it
        if (aQueue.Count > 0)
        {
            Console.WriteLine("First item: " + aQueue.Peek();
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        // Add a new given item newItem to aQueue
        aQueue.Enqueue(newItem);

        // Print if aQueue contains a given item search
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"" + search + "\": " + containsSearch);

        // If aQueue contains the given item search, remove all items up to and including search; otherwise, leave aQueue as is
        bool removedUpToSearch = false;
        while (aQueue.Count > 0)
        {
            string item = aQueue.Dequeue();
            if (!removedUpToSearch && item == search)
            {
                removedUpToSearch = true;
            }
            else if (removedUpToSearch)
            {
                aQueue.Enqueue(item);
            }
        }

        return aQueue;
    }
}
