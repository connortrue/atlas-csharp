using InventoryLibrary;
using System;
using System.Linq;
using System.Collections.Generic;


namespace InventoryManager
{
    class Program
    {
        static JSONStorage storage = new JSONStorage();

        static void Main(string[] args)
        {
            storage.Load();
            PrintPrompt();
            
            while (true)
            {
                string input = Console.ReadLine().Trim().ToLower();
                
                switch (input)
                {
                    case "exit":
                        return;
                    case "classnames":
                        PrintClassNames();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
                
                PrintPrompt();
            }
        }

        static void PrintPrompt()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("{ClassNames} show all ClassNames of objects");
            Console.WriteLine("{All} show all objects");
            Console.WriteLine("{All [ClassName]} show all objects of a ClassName");
            Console.WriteLine("{Create [ClassName]} a new object");
            Console.WriteLine("{Show [ClassName object_id]} an object");
            Console.WriteLine("{Update [ClassName object_id]} an object");
            Console.WriteLine("{Delete [ClassName object_id]} an object");
            Console.WriteLine("{Exit}");
        }

        static void PrintClassNames()
        {
            var classNames = storage.All().Keys.Select(k => k.Split('.')[0]).Distinct().ToList();
            foreach (var className in classNames)
            {
                Console.WriteLine(className);
            }
        }

    }
}
