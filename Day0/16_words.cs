using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine().Trim();
        int countWords = 1;
        
        foreach (char c in str)
        {
            if (c == ' ')
                countWords += 1;
            
        }

        Console.Write(countWords);
    }
}
