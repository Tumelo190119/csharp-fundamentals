using System;

class Program
{
    static void ReverseNumber()
    {
        int number = int.Parse(Console.ReadLine());

        string digit = number.ToString();

        string reverseDigit = string.Empty;

        foreach (char c in digit)
            reverseDigit = c + reverseDigit;

        Console.Write(reverseDigit);
    }

    static void Main()
    {
        ReverseNumber();
    }
}