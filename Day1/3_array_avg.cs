using System;
using System.Globalization;

class Program
{
    static void CalculateArrayStats()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        Console.WriteLine("Sum: " + sum);

        double average = sum / arr.Length;

        Console.Write("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));
    }

    static void Main()
    {
        CalculateArrayStats();
    }
}
