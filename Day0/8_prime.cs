using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number < 2)
        {
            Console.Write("Not Prime");
            return;
        }

        foreach (int i in Enumerable.Range(2, number - 2))
        {
            if (number % i == 0)
            {
                Console.Write("Not Prime");
                return;
            }
        }
        
        Console.Write("Prime");
    }
}
