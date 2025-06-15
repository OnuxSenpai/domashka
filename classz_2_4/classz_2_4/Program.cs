using System;

public class ArraySort
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

        Console.WriteLine("Исходный массив: " + string.Join(" ", array));

        BubbleArray(array);
        Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));
    }

    // пузырчатая сортировка
    public static void BubbleArray(int[] array)
    {
        int n = array.Length; // длина массива

        // сравнение элементов массива меж собой
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // меняем элементы местами
                    int bubble = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = bubble;
                }
            }
        }
    }

    // Функция для вывода массива в консоль
    //public static void PrintArray(int[] array)
    //{
        //foreach (int element in array)
        //{
            //Console.Write(element + " ");
        //}
        //Console.WriteLine();
    //}
}