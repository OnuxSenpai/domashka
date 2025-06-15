using System;
public class MonkeySort
{
    public static void Main()
    {
        Console.WriteLine("Введите размер массива (n):");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: {string.Join(" ", array)}");

        MonkeySortAlgorithm(array);

        Console.WriteLine($"Отсортированный массив: {string.Join(" ", array)}");
    }

    // реализация обезьяньей сортировки
    public static void MonkeySortAlgorithm(int[] array)
    {
        while (!IsSorted(array))
        {
            Random.Shared.Shuffle(array);
            Console.WriteLine($"Перемешиваем: {string.Join(" ", array)}");
        }
    }

    // проверка верности сортировки
    public static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}