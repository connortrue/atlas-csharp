using System;

public class Rectangle
{
  protected int width;
  protected int height;

  public virtual int Width
  {
      get { return width; }
      set { width = value; }
  }

  public virtual int Height
  {
      get { return height; }
      set { height = value; }
  }

  public virtual double Area()
  {
      return width * height;
  }

  public override string ToString()
  {
      return $"[Rectangle] {width} / {height}";
  }
}

public class Square : Rectangle
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
              throw new ArgumentException("Size must be greater than or equal to 0.");
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
