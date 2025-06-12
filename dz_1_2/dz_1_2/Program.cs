using System;

public class Numbers
{
    public static void Main()
    {
        Console.Write("Введите целое число a: ");
        string anum = Console.ReadLine();
        int a = int.Parse(anum);

        Console.Write("Введите целое число b: ");
        string bnum = Console.ReadLine();
        int b = int.Parse(bnum);

        Console.WriteLine(a);
        Console.WriteLine(b);

        a = Math.Abs(a);
        b = Math.Abs(b);

        int n = 0;

        if (b == 0)
        {
            Console.WriteLine("Делитель не может быть нулем.");
        }

        for (n = 0; a >= b; n++)
        {
            a -= b;
        }

        if ((a < 0) ^ (b < 0))
        {
            n = -n;
        }
        
        Console.WriteLine($"Целая часть {n}, остаток {a}");
    }
}