using System;

class Program
{
    static void SumDigits()
    {
        int number = int.Parse(Console.ReadLine());

        string str = "" + number;
        int sum = 0;

        foreach (char digit in str)
        {
            sum = sum + (digit - '0');
        }

        Console.Write(sum);
    }
    static void Main()
    {
        SumDigits();
    }
}