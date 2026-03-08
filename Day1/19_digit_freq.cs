using System;
using System.Linq;
using System.Collections.Generic;

class Program
{    
    static void PrintDigitFrequency()
    {
        List<int> list;

        string number = Console.ReadLine();

        list = number.Select(c => int.Parse(c.ToString())).ToList();

        var result = list.GroupBy(item => item).ToList();

        foreach (var group in result)
        {
            Console.WriteLine($"{group.Key} appears {group.Count()} times");
        }
    }

    static void Main()
    {
        PrintDigitFrequency();
    }
}