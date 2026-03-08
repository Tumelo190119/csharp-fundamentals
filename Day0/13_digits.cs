using System;

class Program
{
    static void Main()
    {
        int digits = int.Parse(Console.ReadLine());
        string number = digits.ToString();
        
        Console.Write(number.Length);
    }
}