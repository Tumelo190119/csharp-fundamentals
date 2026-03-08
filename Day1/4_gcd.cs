using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void FindGCD()
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

        Console.Write(items[items.Count - 1]);
    }

    static void Main()
    {
        FindGCD();
    }
}