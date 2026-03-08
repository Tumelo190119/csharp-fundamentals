using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = System.Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        foreach (int i in Enumerable.Range(0, arr.Length - 1))
        {
            foreach (int j in Enumerable.Range(0, arr.Length - 1))
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.Write("Max: " + arr[0]);
    }
}