using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of the elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T value { get; set; }

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node next { get; set; }

        /// <summary>
        /// Initializes a new instance of the Node class with the specified value.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// Gets or sets the head of the queue.
    /// </summary>
    private Node head;

    /// <summary>
    /// Gets or sets the tail of the queue.
    /// </summary>
    private Node tail;

    /// <summary>
    /// Gets or sets the count of the elements in the queue.
    /// </summary>
    private int count;

    /// <summary>
    /// Initializes a new instance of the Queue class.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds a new element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
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

    /// <summary>
    /// Returns the number of elements in the queue.
    /// </summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Removes and returns the value at the beginning of the queue.
    /// </summary>
    /// <returns>The value at the beginning of the queue.</returns>
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

    /// <summary>
    /// Returns the value at the beginning of the queue without removing it.
    /// </summary>
    /// <returns>The value at the beginning of the queue.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    /// <summary>
    /// Prints the values in the queue.
    /// </summary>
    public void Print()
    {
        Node current = head;

        if (current == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        while (current != null)
        {
            Console.Write(current.value);
            current = current.next;
            if (current != null)
            {
                Console.Write("\n");
            }
        }

        Console.WriteLine();
    }
}
