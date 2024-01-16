using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        Type objectType = myObj.GetType();
        Console.WriteLine($"{objectType.Name} Properties:");
        foreach (PropertyInfo property in objectType.GetProperties())
        {
            Console.WriteLine(property.Name);
        }
        Console.WriteLine($"{objectType.Name} Methods:");
        foreach (MethodInfo method in objectType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
