using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            if (i < 10)
            {
                Console.Write($"0{i}");
            }
            else if (i == 99)
            {
                Console.Write(i + "\n");
                break;
            }
            else
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
