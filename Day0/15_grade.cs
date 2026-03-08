using System;

class Program
{
    static void GradeCalc()
    {
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90 && grade <= 100)
            Console.Write('A');
        else if (grade >= 80 && grade <= 89)
            Console.Write('B');
        else if (grade >= 70 && grade <= 79)
            Console.Write('C');
        else if (grade >= 60 && grade <= 69)
            Console.Write('D');
        else
            Console.Write('F');
    }

    static void Main()
    {
        GradeCalc();
    }
}