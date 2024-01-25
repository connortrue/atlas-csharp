using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of the elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of the elements in the queue.
    /// </summary>
    /// <returns>The type of the elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
