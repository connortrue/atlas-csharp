using System;

public class Shape
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

public class Rectangle : Shape
{
   private int width;
   private int height;

   public int Width
   {
       get { return width; }
       set 
       { 
           if (value < 0)
               throw new ArgumentException("Width must be greater than or equal to 0.");
           else
               width = value; 
       }
   }

   public int Height
   {
       get { return height; }
       set 
       { 
           if (value < 0)
               throw new ArgumentException("Height must be greater than or equal to 0.");
           else
               height = value; 
       }
   }
}
