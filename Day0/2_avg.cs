using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float average = (a + b + c) / 3;

        Console.Write("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));
    }
}