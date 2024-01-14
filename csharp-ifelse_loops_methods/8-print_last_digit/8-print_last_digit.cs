using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number) % 10; // get the last digit
        Console.WriteLine(lastDigit); // print it
        return lastDigit; // return it
    }
}
