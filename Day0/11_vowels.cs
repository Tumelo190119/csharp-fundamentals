using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int countVowels = 0;
        foreach (char c in s)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                countVowels += 1;
        }
        Console.Write(countVowels);
    }
}