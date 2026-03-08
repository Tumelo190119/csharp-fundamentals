using System;
using System.Collections.Generic;

class Porgram
{
    static void CheckArmstrong()
    {
        List<int> list = new List<int>();

        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;

        while (number > 0)
        {
            list.Add((int)Math.Pow(number % 10, 3));
            number = number / 10;
        }

        int listSum = 0;
        foreach (int digit in list)
        {
            listSum += digit;
        }

        if (listSum == originalNumber)
            Console.Write("Armstrong number");
        else
            Console.Write("Not an Armstrong number");
    }

    static void Main()
    {
        CheckArmstrong();
    }
}