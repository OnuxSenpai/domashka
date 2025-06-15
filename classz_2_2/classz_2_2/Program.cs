using System;
using System.Linq;

public class MaxAndSecondMaxArray
{
    public static void Main()
    {
        Console.WriteLine("Введите 10 различных чисел:");

        int[] array = new int[10]; // новый массив длиной 10

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = array.Max(); // сразу находим максимальное число
        List<int> listnomax = new List<int>(); // сборка списка всех чисел кроме максимального

        // отбор чисел меньше наибольшего числа
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != max) // проверкка неравенства с наибольшим числом
            {
                listnomax.Add(array[i]); // если число прошло проверку, то добавляем его в 
            }
        }
        Console.WriteLine(listnomax);
        int[] arraynomaxnum = listnomax.ToArray(); // превращаем список в массив

        int secmax = arraynomaxnum.Max(); // находим второе по величине число

        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Следующее по величине число: {secmax}");
    }
}