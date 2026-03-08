using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int factorial = 1;
    
        foreach(int i in Enumerable.Range(1, number))
        {
            factorial *= i;
        }
        Console.Write(number + "! = " + factorial);
    }
}