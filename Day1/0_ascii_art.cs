using System;
using System.Linq;

class Program
{
    static void PrintAsciiArt()
    {
        int number = int.Parse(Console.ReadLine());

        foreach (int i in Enumerable.Range(1, number))
        {
            Console.WriteLine(new string('*', i));
        }
    }

    static void Main()
    {
        PrintAsciiArt();
    }

}