using System;

public class Numbers
{
    public static void Main()
    {
        Console.Write("Введите число a: ");
        string anum = Console.ReadLine();
        double a = double.Parse(anum);

        Console.Write("Введите число b: ");
        string bnum = Console.ReadLine();
        double b = double.Parse(bnum);

        Console.Write("Введите число c: ");
        string cnum = Console.ReadLine();
        double c = double.Parse(cnum);


        double astep = Math.Pow(a, 2);
        double bstep = Math.Pow(b, 2);
        double cstep = Math.Pow(c, 2);

        double scob1 = Math.Pow(a * b + 7 * c, 3);

        var otv = (scob1 - (astep + bstep  + cstep)) / (b - a * c - a * (b + c));
        Console.WriteLine(otv);
    }
}