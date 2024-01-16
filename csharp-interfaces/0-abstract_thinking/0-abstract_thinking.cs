using System;

public abstract class Base
{
   public string Name { get; set; }

   public override string ToString()
   {
       return $"{this.Name} is a {this.GetType().Name}";
   }
}

public class SoftwareEngineer : Base
{
}
