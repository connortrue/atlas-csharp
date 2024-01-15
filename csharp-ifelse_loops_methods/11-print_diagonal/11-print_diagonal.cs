using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(new string(' ', i) + "\\");
            }
        }
        else
        {
            Console.WriteLine();
        }
    }
}
