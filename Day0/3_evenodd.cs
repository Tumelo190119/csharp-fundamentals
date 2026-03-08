using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
            Console.Write("Even");
        else
            Console.Write("Odd");
    }
}