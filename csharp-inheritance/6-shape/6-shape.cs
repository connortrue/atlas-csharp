using System;

public class Shape
{
    public void int Area()
    {
        return 0;
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

    public void int Area()
    {
        return width * height;
    }
}
