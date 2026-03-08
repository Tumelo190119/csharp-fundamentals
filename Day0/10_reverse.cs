using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string newStr = str.Trim();
        string reversed = new string(newStr.Reverse().ToArray());
        Console.Write(reversed);
    }
}