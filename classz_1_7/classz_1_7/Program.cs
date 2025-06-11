using System;

public class Numbers
{
    public static void Main()
    {
        Console.Write("Введите вещественное число a: ");
        string anum = Console.ReadLine();
        double a = double.Parse(anum);

        Console.Write("Введите знак арифметической операции: ");
        string znak = Console.ReadLine();

        Console.Write("Введите вещественное число b: ");
        string bnum = Console.ReadLine();
        double b = double.Parse(bnum);

        if (znak == "+")
        {
            Console.Write(a+b);
        }    
        if (znak == "-")
        {
            Console.Write(a-b);
        }
        if (znak == "*")
        {
            Console.Write(a*b);
        }
        if (znak == "/")
        {
            Console.Write(a/b);
        }
        if (znak == "^")
        {
            Console.WriteLine(Math.Pow(a, b));
        }
    }
}