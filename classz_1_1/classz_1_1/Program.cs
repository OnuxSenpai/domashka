using System;
public class Numbers
{
    public static void Main()
    {
        Console.WriteLine("Введите переменную a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите переменную b:");
        int b = Convert.ToInt32(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"Произошла смена переменных. Переменная a = {a}, переменная b = {b}");
    }
}