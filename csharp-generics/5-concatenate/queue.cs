using System;

public class Queue<T>
{
    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    public int Count()
    {
        return count;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;

        if (head == null)
        {
            tail = null;
        }

        count--;

        return value;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.Write(current.value + " ");
            current = current.next;
        }

        Console.WriteLine();
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (!typeof(T).Equals(typeof(string)) && !typeof(T).Equals(typeof(char)))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        StringBuilder sb = new StringBuilder();
        Node current = head;
        while (current != null)
        {
            sb.Append(current.value.ToString());
            current = current.next;
        }

        return sb.ToString();
    }
}
