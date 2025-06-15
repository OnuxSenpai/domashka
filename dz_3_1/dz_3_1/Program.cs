using System;

public class NumberBin
{
    public static void Main()
    {
        // в этой части программы запрос на числа и вывод в консоль всего решения

        Console.Write("Введите первое целое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе целое число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите какое кол-во бит использовать для представления чисел (обычно лучше 8): "); // это потом пригодится
        int numbits = Convert.ToInt32(Console.ReadLine());

        string bin1 = GoToBin(num1, numbits);
        string bin2 = GoToBin(num2, numbits);
        Console.WriteLine($"{num1} в двоичном виде: {bin1}");
        Console.WriteLine($"{num2} в двоичном виде: {bin2}");

        string sumbin = PlusBin(bin1, bin2);
        Console.WriteLine($"Сумма в двоичном виде: {sumbin}");

        int sumnorm = BinToNorm(sumbin);
        Console.WriteLine($"Сумма в десятичном виде: {sumnorm}");
    }

    // преобразование десятичного числа в двоичный код (дополнительный код)
    static string GoToBin(int num, int numbits) // number берёт десятичное число, numbits берёт кол-во битов
    {
        string bin = Convert.ToString(num, 2); // преобразование числа в двоичный код
        bin = bin.PadLeft(numbits, '0'); // добавляем недостающие нули, чтобы было нужное кол-во символов

        if (bin.Length > numbits) // если число отрицательное, то обрезаем лишние символы
        {
            bin = bin.Substring(bin.Length - numbits); // Substring говорит сколько символов убрать
        }
        return bin;
    }

    // сложениe двух двоичных чисел
    static string PlusBin(string bin1, string bin2)
    {
        // наверняка при работе с положительными числами длина их двоичных чисел будет разной
        int maxlen = Math.Max(bin1.Length, bin2.Length); // Math.Max вычисляет у кого больше всего символов с помощью lenght
        bin1 = bin1.PadLeft(maxlen, '0'); // PadLeft добавляет нули, пока длины не сравняются
        bin2 = bin2.PadLeft(maxlen, '0'); // здесь делается тоже самое

        string result = ""; // сборка итогового числа при суммировании
        int ost = 0; // остаток

        // суммирование битов справа налево
        for (int i = maxlen - 1; i >= 0; i--)
        {
            int bit1 = int.Parse(bin1[i].ToString()); // с помощью индекса берём цифру из числа в виде строки и превращаем в число для дальнейших вычислений
            int bit2 = int.Parse(bin2[i].ToString()); // тоже самое

            int sum = bit1 + bit2 + ost; // сумма битов и остатка

            // разборки с остатком (если он вообще есть)
            if (sum == 0)
            {
                result = "0" + result;
                ost = 0;
            }
            else if (sum == 1)
            {
                result = "1" + result;
                ost = 0;
            }
            else if (sum == 2)
            {
                result = "0" + result;
                ost = 1;
            }
            else // если sum == 3
            {
                result = "1" + result;
                ost = 1;
            }
        }
        // ести в итоге остался остаток, то добавляем его в начало
        if (ost == 1)
        {
            result = "1" + result;
        }
        if (result.Length > maxlen)
        {
            result = result.Substring(1);
        }
        return result;
    }

    // преобразование двоичного кода (дополнительный код) в десятичное число
    static int BinToNorm(string bin)
    {
        int des = 0; // сборка числа в десятичном виде
        int dva = 1; // это грубо говоря счётчик увеливающий степень двоек

        // Идем с конца двоичного кода к началу
        for (int i = bin.Length - 1; i >= 0; i--) // снова работа с индексами
        {
            if (bin[i] == '1') 
            {
                des += dva; // работа с двойками осуществляется только тогда, когда бит равен 1
            }
            dva *= 2; // увеличение степени следующей двойки
        }

        // если работаем с отрицательным числом, то из итгового десятичного варианта вычитываем двойку в (максималоьной) степени длины двоичного числа
        if (bin[0] == '1')
        {
            des -= (int)Math.Pow(2, bin.Length);
            Console.WriteLine(des);
        }
        return des;
    }
}