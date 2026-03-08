using System;
using System.Globalization;

class Program
{
    static void Calculator()
    {
        float num1 = float.Parse(Console.ReadLine());
        string sign = Console.ReadLine();
        float num2 = float.Parse(Console.ReadLine());

        float res = 0;

        if (sign == "+")
            res = num1 + num2;
        else if (sign == "-")
            res = num1 - num2;
        else if (sign == "/")
            res = num1 / num2;
        else if (sign == "*")
            res = num1 * num2;

        if (sign == "/")
            Console.Write(res.ToString("F2", CultureInfo.InvariantCulture));
        else
            Console.Write(res);
    }

    static void Main()
    {
        Calculator();
    }
}