using System;

public class Square
{
    public virtual int Area()
    {
        return 0;
    }

    public override string ToString()
    {
        return "Generic Shape";
    }
}

public class Rectangle : Square
{
    private int size;

    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Width = value;
            Height = value;
        }
    }

    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
