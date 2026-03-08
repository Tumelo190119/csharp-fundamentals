using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void FindDuplicates()
    {
        int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        List<int> duplicates = new List<int>();

        var result = list.GroupBy(item => item).ToList();

        foreach (var group in result)
        {
            if (group.Count() > 1)
            {
                duplicates.Add(group.Key);
            }
        }

        foreach (int dup in duplicates)
        {
            Console.Write(dup + " ");
        }
    }

    static void Main()
    {
        FindDuplicates();
    }
}