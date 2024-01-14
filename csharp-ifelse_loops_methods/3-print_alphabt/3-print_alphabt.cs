using System;

class Program
{
    static void Main()
    {
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (c != 'e' && c != 'q')
            {
                Console.Write(c);
            }
        }
    }
}
