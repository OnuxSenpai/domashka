using System;

public class Numbers
{
    public static void Main()
    {
        Console.WriteLine("Введите дилны сторон первого треугольника: ");

        string sa1 = Console.ReadLine();
        double a1 = double.Parse(sa1);
        string sb1 = Console.ReadLine();
        double b1 = double.Parse(sb1);
        string sc1 = Console.ReadLine();
        double c1 = double.Parse(sc1);

        Console.WriteLine("Введите длины сторон второго треугольника: ");
        string sa2 = Console.ReadLine();
        double a2 = double.Parse(sa2);
        string sb2 = Console.ReadLine();
        double b2 = double.Parse(sb2);
        string sc2 = Console.ReadLine();
        double c2 = double.Parse(sc2);

        var del1 = a1 / a2;
        var del2 = b1 / b2;
        var del3 = c1 / c2;

        if ((del1 == del2) && (del1 == del2)) {Console.WriteLine("Да");}
        else { Console.WriteLine("Нет");}
    }
}