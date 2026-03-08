using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = new List<int> {0, 1};
        int number = int.Parse(Console.ReadLine());
        int next;

        foreach (int i in Enumerable.Range(2, number - 1))
        {
            next = list[list.Count - 1] + list[list.Count - 2];
            list.Add(next);
        }
        
        foreach (int num in list.Take(list.Count - 1))
        {
            Console.Write(num + " ");
        }
    }
}
