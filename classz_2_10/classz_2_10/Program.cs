using System;
public class AverageCalculator
{
    public static void Main()
    {
        Console.WriteLine("Введите вещественные числа через пробел:");
        string input = Console.ReadLine();

        // массив из вещественных чисел
        string[] numstrsss = input.Split(' ');

        // новый список, хранилище для вещественных чисел из строкового значения
        List<double> numlist = new List<double>();

        // перебор всех элементов массива для преобразования из строки в вещественное число
        for (int i = 0; i < numstrsss.Length; i++)
        {
            string num = numstrsss[i];
            // преобразование одного из чисел в из строкового вида в вещественный
            bool conversionSuccessful = double.TryParse(num, out double number);

            // добавление числа в хранилище
            numlist.Add(number);
        }

        // преобразование списка из чисел в массив
        double[] numbers = numlist.ToArray();

        double arifm = Arifm(numbers);
        Console.WriteLine($"Среднее арифметическое: {arifm}");
    }

    public static double Arifm(double[] numbers)
    {
        double sum = 0; // накопитель суммы всех чисел в массиве
        foreach (double number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length; // деление суммы чисел на их количество
    }
}