using System;

public class Queue<T>
{
    private Node<T> head;
    private Node<T> tail;

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = head;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.Value;
        head = head.Next;
        if (head == null)
        {
            tail = null;
        }
        return value;
    }
}

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
}
