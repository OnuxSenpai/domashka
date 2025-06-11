using System;

public class Numbers
{
    public static void Main()
    {
        double ooot = 10;
        double dooo = 15;
        double shag = 0.5;

        // Выводим заголовок таблицы
        Console.WriteLine("----------------------------");
        Console.WriteLine("| Таблица значений функции |");
        Console.WriteLine("----------------------------");
        Console.WriteLine("|  x   |f(x)=sin(x^2)*ln(x)|");
        Console.WriteLine("----------------------------");

        for (double x = ooot; x <= dooo; x += shag)
        {
            double fx = Math.Sin(x * x) * Math.Log(x);
            Console.WriteLine($"| {x,4:F1} | {fx,16:F10}  |");
        }
        Console.WriteLine("----------------------------");
    }
}