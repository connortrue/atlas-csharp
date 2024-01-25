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
            this.next = null;
        }
    }

    /// <summary>
    /// Gets or sets the head of the queue.
    /// </summary>
    public Node head { get; set; }

    /// <summary>
    /// Gets or sets the tail of the queue.
    /// </summary>
    public Node tail { get; set; }

    /// <summary>
    /// Gets or sets the count of the elements in the queue.
    /// </summary>
    public int count { get; set; }

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
            tail = head;
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
}
