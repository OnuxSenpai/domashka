using System;

public class Gipoteza
{
    public static void Main()
    {
        Console.WriteLine("Введите число n:");
        int n = int.Parse(Console.ReadLine());

        int steps = Steps(n);
        Console.WriteLine($"Число замен, приводящих до 1: {steps}");
    }
    public static int Steps(int n)
    {
        int steps = 0;
        while (n != 1)
        {
            if (n % 2 == 0) // проверка на четность
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
            steps++;
        }
        return steps;
    }
}