using System;
using System.Collections.Generic;

public class MyStack
{
  public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
  {
      // Print the number of items in aStack
      Console.WriteLine("Number of items: " + aStack.Count);

      // Print the item at the top of aStack without removing it
      if (aStack.Count > 0)
      {
          Console.WriteLine("Top item: " + aStack.Peek());
      }
      else
      {
          Console.WriteLine("Stack is empty");
      }

      // Print if aStack contains a given item search
      bool containsSearch = aStack.Contains(search);
      Console.WriteLine("Stack contains \"" + search + "\": " + containsSearch);

      // Convert the stack into an array
      string[] arr = aStack.ToArray();

      // Find the index of the search item in the array and remove all items from the index of the search item to the end of the array
      int index = Array.IndexOf(arr, search);
      if (index >= 0)
      {
          arr = arr.Take(index).ToArray();
      }

      // Add the new item to the array
      List<string> list = new List<string>(arr);
      list.Add(newItem);

      // Convert the list back into a stack
      Stack<string> result = new Stack<string>(list);

      return result;
  }
}
