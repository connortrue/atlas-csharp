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
  private int size;

  public int Size
  {
      get
      {
          return size;
      }
      set
      {
          if (value < 0)
          {
              throw new ArgumentException("Size must be greater than or equal to 0");
          }
          else
          {
              size = value;
              base.Width = value;
              base.Height = value;
          }
      }
  }

  public override string ToString()
  {
      return $"[Square] {size} / {size}";
  }
}
