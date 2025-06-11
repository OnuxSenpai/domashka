using System;
public class Numbers
{
    public static void Main()
    {
        // обработка введённого числа
        Console.WriteLine("Введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            bool danet = true; // булка воспринимает тру и фолс

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0) // Проверка на простое число
                {
                    danet = false; // Если нет, то фолс
                    break; // Выход из цикла для j
                }
            }

            if (danet == true) // Если тру, то число простое
            {
                Console.WriteLine(i); // Вывод числа на консоль
            }
        }
    }
}