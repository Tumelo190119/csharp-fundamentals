using System;
using System.Linq;

class Program
{
    static void CheckPerfectNumber()
    {
        int number = int.Parse(Console.ReadLine());

        int sumOfFactors = 0;

        foreach (int i in Enumerable.Range(1, number - 1))
        {
            if (number % i == 0)
                sumOfFactors = sumOfFactors + i;
        }

        if (number == sumOfFactors)
            Console.Write("Perfect number");
        else
            Console.Write("Not a Perfect number");
    }

    static void Main()
    {
        CheckPerfectNumber();
    }
}