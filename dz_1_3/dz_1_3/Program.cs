using System;

public class Numbers
{
    public static void Main()
    {
        Console.Write("Введите коэффициет a: ");
        string anum = Console.ReadLine();
        double a = double.Parse(anum);

        Console.Write("Введите коэффициент b: ");
        string bnum = Console.ReadLine();
        double b = double.Parse(bnum);

        Console.Write("Введите коэффициент c: ");
        string cnum = Console.ReadLine();
        double c = double.Parse(cnum);

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Бесконечно много решений.");
                }
                else
                {
                    Console.WriteLine("Нет решений.");
                }
            }
            else
            {
                Console.WriteLine("Один корень:");
                Console.WriteLine((c * (-1)) / b);
            }
        }
        else
        {
            var dis = Math.Pow(b, 2) - 4 * a * c;

            if (dis > 0)
            {
                Console.WriteLine("Два корня:");
                Console.WriteLine((b * (-1) + Math.Sqrt(dis)) / (2 * a));
                Console.WriteLine((b * (-1) - Math.Sqrt(dis)) / (2 * a));
            }
            else if (dis == 0)
            {
                Console.WriteLine("Один корень:");
                Console.WriteLine((b * (-1)) / (2 * a));
            }
            else
            {
                Console.WriteLine("Нет корней.");
            }
        }
    }
}