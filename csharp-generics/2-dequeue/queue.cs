using System;

public class Queue<T>
{
    private Node<T> _head;
    private Node<T> _tail;

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
        if (_head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = _head.Value;
        _head = _head.Next;
        if (_head == null)
        {
            _tail = null;
        }
        return value;
    }
}

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
}
