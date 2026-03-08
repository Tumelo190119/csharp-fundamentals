using System;

class Program
{
    static void BubbleSort()
    {
        int[] list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int i = 0;
        while (i < list.Length - 1)
        {
            int j = 0;
            while (j < list.Length - 1)
            {
                if (list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
                j++;
            }
            i++;
        }

        Console.Write(string.Join(" ", list));
    }

    static void Main()
    {
        BubbleSort();
    }
}