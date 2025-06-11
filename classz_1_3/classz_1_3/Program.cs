using System;
public class Numbers
{
    public static void Main()
    {
        Console.WriteLine("Введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int num = n;

        while (num > 0)
        {
            n = 1;
            for (int i = num; i > 0; i--)
            {
                n *= i;
            }
            Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
            num--;
        }
    }
}