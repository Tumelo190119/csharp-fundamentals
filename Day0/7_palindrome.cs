using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string newStr = str.Replace(" ", "");
        string reversed = new string(newStr.Reverse().ToArray());
        
        if (newStr.ToLower() == reversed.ToLower())
            Console.WriteLine("Palindrome");
        else
            Console.Write("Not a Palindrome");
    }
}