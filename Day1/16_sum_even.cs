using System;

class Program
{
    static void SumEvenNumbers()
    {
        int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int sum = 0;

        foreach (int num in list)
        {
            if (num % 2 == 0)
                sum = sum + num;
        }

        Console.Write(sum);
    }

    static void Main()
    {
        SumEvenNumbers();
    }
}