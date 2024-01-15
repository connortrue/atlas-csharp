using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (count == 0)
                {
                    Console.Write($"{i}{j:D2}");
                }
                else
                {
                    Console.Write($", {i}{j:D2}");
                }
                count++;
            }
        }
    }
}
