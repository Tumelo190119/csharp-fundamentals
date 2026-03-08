using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        
        foreach (int i in Enumerable.Range(1, 10))
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }
}