using System;
using System.Linq;

class Program
{
    static string IsAscending()
    {
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int prev = array[0];
        foreach (int num in array.Skip(1))
        {
            if (prev > num)
            {
                return "Not Ascending";
            }
            prev = num;
        }

        return "Ascending";
    }

    static void Main()
    {
        string result = IsAscending();
        Console.Write(result);
    }
}