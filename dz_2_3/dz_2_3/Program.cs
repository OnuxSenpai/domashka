using System;

class Number
{
    static void Main()
    {
        Console.WriteLine("Введите вещественное число -1 <= x <= 1: ");
        double x = Convert.ToDouble(Console.ReadLine());

        int k = 0; // это счётчик для степеней и факториалов
        double e = 1; // сборка итогового ответа
        double slag = 0; // здесь будут значения каждого слагаемого для сравнения

        while (Math.Abs(slag) > Math.Pow(10, -6)) // сравнение, для выполнения условия
        {
            k++;
            slag = Math.Pow(x, k) / Fac(k);
            e += slag;
        }
        Console.WriteLine($"Приближение к e^x = {e}");
    }
    // вычисление факториала
    static long Fac(int k)
    {
        long fac = 1;
        for (int i = 1; i <= k; i++)
        {
            fac *= i;
        }
        return fac;
    }
}