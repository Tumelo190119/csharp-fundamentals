using System;
using System.Collections.Generic;

class Program
{
    static void PrintFibonacciUpTo()
    {
        List<int> list = new List<int> {0, 1};

        int limit = int.Parse(Console.ReadLine());

        if (limit == 0)
            return;

        int next;

        int i = 2;
        while (list[list.Count - 1] + list[list.Count - 2] <= limit)
        {
            next = list[list.Count - 1] + list[list.Count - 2];
            list.Add(next);
            i++;
        }

        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
    }

    static void Main()
    {
        PrintFibonacciUpTo();
    }
}