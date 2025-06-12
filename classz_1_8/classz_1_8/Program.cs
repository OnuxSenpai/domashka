using System;

public class Numbers
{
    public static void Main()
    {
        Console.Write("Введите целое число копеек (до рубля включительно): ");
        int dengi = Convert.ToInt32(Console.ReadLine());

        if (dengi < 0 || dengi > 100)
        {
            Console.WriteLine("Неправильное целое число. Соблюдайте условие задания.");
            return;
        }

        Console.WriteLine(Kop(dengi));
    }

    public static string Kop(int kop)
    {
        string[] ed = { "одна", "две", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        string[] desand = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
        string[] des = { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
        string[] sto = { "сто" };

        string result = "";

        if (kop == 0)
        {
            result = "ноль копеек";
            return result;
        }

        if (kop == 100)
        {
            result = "сто копеек";
            return result;
        }

        if (kop < 10)
        {
            result = ed[kop - 1];
        }
        else if (kop >= 10 && kop <= 19)
        {
            result = desand[kop - 10];
        }
        else
        {
            int desyatki = kop / 10;
            int edinici = kop % 10;

            if (edinici == 0)
            {
                result = des[desyatki - 2];
            }
            else
            {
                result = des[desyatki - 2] + " " + ed[edinici - 1];
            }
        }

        string[] kopSuffix = { "копейка", "копейки", "копеек" };

        if (kop % 10 == 1 && kop != 11)
        {
            result += " " + kopSuffix[0];
        }
        else if (kop % 10 >= 2 && kop % 10 <= 4 && (kop < 10 || kop > 20))
        {
            result += " " + kopSuffix[1];
        }
        else
        {
            result += " " + kopSuffix[2];
        }


        return result;
    }
}