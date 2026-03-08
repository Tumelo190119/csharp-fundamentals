using System;

class Program
{
    static void LinearSearch()
    {
        int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int number = int.Parse(Console.ReadLine());

        int times = 0;

        foreach (int item in list)
        {
            if (item == number)
                times = times + 1;
        }

        Console.Write(times);
    }

    static void Main()
    {
        LinearSearch();
    }
}