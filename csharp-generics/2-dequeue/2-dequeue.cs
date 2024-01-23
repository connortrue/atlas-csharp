public class Queue<T>
{
    private Node<T> _head;
    private Node<T> _tail;

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
