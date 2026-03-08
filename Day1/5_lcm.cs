using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void FindLCM()
    {
        List<int> items = new List<int>();

        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        foreach (int i in Enumerable.Range(1, Math.Min(num1, num2)))
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                items.Add(i);
            }
        }

        int numerator = num1 * num2;
        int denominator = items[items.Count - 1];

        int lcm = numerator / denominator;

        Console.Write(lcm);
    }

    static void Main()
    {
        FindLCM();
    }
}