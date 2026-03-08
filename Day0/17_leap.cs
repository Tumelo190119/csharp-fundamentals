using System;

class Program
{
    static void LeapYearCheck()
    {
        int year = int.Parse(Console.ReadLine());

        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            Console.Write("Leap year");
        else
            Console.Write("Not a leap year");
    }

    static void Main()
    {
        LeapYearCheck();
    }
}