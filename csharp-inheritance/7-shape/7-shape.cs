using System;

public class Shape
{
    public virtual int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return "Generic Shape";
    }
}

public class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    public override int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}
