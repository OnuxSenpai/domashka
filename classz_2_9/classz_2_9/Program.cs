using System;

public class SredneeArifmeticheskoe
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите три вещественных числа через пробел:");
        string input = Console.ReadLine();

        // массив из раздробленных строк
        string[] numstr = input.Split(' ');

        // новый массив длиной 3 для хранения вещественных чисел
        double[] num = new double[3];

        // заполнение массива numbers преобразованными из строк вещественными числами
        num[0] = double.Parse(numstr[0]);
        num[1] = double.Parse(numstr[1]);
        num[2] = double.Parse(numstr[2]);

        Arrif(num);

        Console.WriteLine($"Измененные значения: {num[0]}, {num[1]}, {num[2]}");
    }

    // замена значений элементов массива на среднее арифметическое двух других элементов.
    public static void Arrif(double[] num)
    {
        double[] originalNumbers = (double[])num.Clone(); // копия массива

        num[0] = (originalNumbers[1] + originalNumbers[2]) / 2.0;
        num[1] = (originalNumbers[0] + originalNumbers[2]) / 2.0;
        num[2] = (originalNumbers[0] + originalNumbers[1]) / 2.0;
    }
}