public class Queue<T>
{
    private List<T> _elements = new List<T>();

    public Type CheckType()
    {
        return _elements[0]?.GetType();
    }
}
