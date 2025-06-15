using System;
class Program
{
    static void Main()
    {
        // создаём сборку для случайных чисел

        Console.WriteLine("Введите количество чисел в массиве: ");
        string strel = Console.ReadLine();
        int el = Convert.ToInt32(strel); // количество элементов в массиве
        int[] array;
        array = new int[el]; // создаем массив с заданной длиной
        Random rand = new Random();


        // рандомайзер случайных чисел
        for (int i = 0; i < el; i++)
        {
            array[i] = rand.Next(10, 999); // метод Next генерирует случайное число
        }

        // вывод массива из случайных чисел
        Console.WriteLine("Массив из случайных чисел:");
        foreach (var e in array)
        {
            Console.WriteLine(e);
        }
        SumNum(array);
    }

    // перебор чисел с максимальной суммой цифр
    static void SumNum(int[] array)
    {
        int max_sum = 0;
        List<int> maxnum = new List<int>(); // создание списка чисел с максимальной суммой

        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;

            if (array[i] >= 10 && array[i] < 100) // проверка на двузначность числв
            {
                sum = array[i] % 10 + array[i] / 10; // сумма цифр двузначного числа
            }
            else if (array[i] >= 100 && array[i] <= 999) // проверка на трехзначное число
            {
                sum = array[i] % 10 + (array[i] / 10) % 10 + array[i] / 100; // сумма цифр трехзначного числа
            }

            if (sum > max_sum) // если сумма больше максимальной
            {
                max_sum = sum; // обновление максимальной суммы
                maxnum.Clear(); // чистка списка
                maxnum.Add(array[i]); // добавляем в список новое число с более большой суммой цифр
            }
            else if (sum == max_sum) // если сумма равна максимальной сумме
            {
                maxnum.Add(array[i]); // добавляем число к списку
            }
        }
        // вывод числа (или чисел) с максимальной суммой цифр
        Console.WriteLine($"Максимальная сумма цифр в одном числе: {max_sum}");
        Console.WriteLine($"Числа с максимальной суммой цифр: {string.Join(", ", maxnum)}"); // string.Join меж числами впихивает запятые с пробелами
    }
}