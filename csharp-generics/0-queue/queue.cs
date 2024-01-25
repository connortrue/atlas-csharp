using System;

public class Queue<T>
{
    public Type CheckType()
    {
        return _elements[0]?.GetType();
    }
}
