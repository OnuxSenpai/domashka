using System;
public class Okryzhnost
{
    public static void Main()
    {
        Console.WriteLine("Введите радиус окружности: ");
        int rad = Convert.ToInt32(Console.ReadLine());

        char star = '*';

        // проход по столбцам
        for (int y = -rad; y <= rad; y++)
        {
            // проход по строкам
            for (int x = -rad; x <= rad; x++)
            {
                // грубо говоря рассчет гипотенузы
                double gip = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                // если погрешность меж гипотенузой и радиусом не велика, то печатаем звезду, иначе пробел
                if (Math.Abs(gip - rad) < 0.2)
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            // переход на новую строку
            Console.WriteLine();
        }
    }
}