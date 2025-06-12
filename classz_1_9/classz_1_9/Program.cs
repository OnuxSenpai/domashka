using System;

public class Numbers
{
    public static void Main()
    {
        Console.Write("Введите вещественное число: ");
        string anum = Console.ReadLine();
        double a = double.Parse(anum);

        Console.Write("Введите единицу измерений, которую хотите поменять: ");
        string znak1 = Console.ReadLine();

        Console.Write("Введите единицу измерений, на которую вы хотите поменять: ");
        string znak2 = Console.ReadLine();

        if (znak1 == "т")
        {
            if (znak2 == "ц")
            {
                a = a * 10;
            }
            if (znak2 == "к")
            {
                a = a * 1000;
            }
            if (znak2 == "г")
            {
                a = a * 1000000;
            }
        }
        if (znak1 == "ц")
        {
            if (znak2 == "т")
            {
                a = a / 10;
            }
            if (znak2 == "к")
            {
                a = a * 100;
            }
            if (znak2 == "г")
            {
                a = a * 100000;
            }
        }
        if (znak1 == "к")
        {
            if (znak2 == "т")
            {
                a = a / 1000;
            }
            if (znak2 == "ц")
            {
                a = a / 100;
            }
            if (znak2 == "г")
            {
                a = a * 1000;
            }
        }
        if (znak1 == "г")
        {
            if (znak2 == "т")
            {
                a = a / 1000000;
            }
            if (znak2 == "ц")
            {
                a = a / 100000;
            }
            if (znak2 == "к")
            {
                a = a / 1000;
            }
        }
        Console.WriteLine(a);
    }
}