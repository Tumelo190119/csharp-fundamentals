using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        float f = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float c = (f - 32) * 5 / 9;
        
        Console.Write("Celsius: " + c.ToString("F1", CultureInfo.InvariantCulture));
    }
}