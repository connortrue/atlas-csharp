using System;

public class Rectangle
{
   public virtual int Width { get; set; }
   public virtual int Height { get; set; }

   public Rectangle(int width, int height)
   {
       Width = width;
       Height = height;
   }
}

public class Square : Rectangle
{
   private int size;

   public int Size
   {
       get { return size; }
       set
       {
           if (value < 0)
               throw new ArgumentException("Size must be greater than or equal to 0");
           else
           {
               size = value;
               Height = value;
               Width = value;
           }
       }
   }
}
