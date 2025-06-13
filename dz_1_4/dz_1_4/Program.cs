using System;

public class NumbersBit
{
    public static void Main()
    {
        // это просто жесть.
        // короче код точно правильно работает для положительных чисел.
        // я хз, надо было ещё отрицательные обрабатывать или нет.
        // в итоге сделала и для отрицательных. вроде тоже правильный результат выводит.

        //  делаю "заготовки" чисел в битовом виде
        int bin1 = 0;
        int bin2 = 0;
        int bin3 = 0;

        // и кол-ва символов в числах в битовом виде
        int simvol1 = 0;
        int simvol2 = 0;
        int simvol3 = 0;

        Console.WriteLine("Введите три целых числа:");

        int num1 = int.Parse(Console.ReadLine()); // ввод первого числа

        // определение знака первого числа и перевод в бинарный вид
        if (num1 < 0)
        {
            int modnum1 = Math.Abs(num1); // модуль
            string strmodbin1 = Convert.ToString(modnum1, 2); // в положит. строковой бинарный
            int simvolmod1 = strmodbin1.Length; // кол-во символов в положит. бинарном
            string strbin1 = Convert.ToString(num1, 2); // в отриц. строковой бинарный
            string lastbin1 = strbin1.Substring(strbin1.Length - (simvolmod1+1)); // отброс лишних единиц

            simvol1 = strbin1.Length; // кол-во символов в отриц. бинарном

            bin1 = int.Parse(lastbin1); // перевод в числовой
        }
        else
        {
            string strbin1 = Convert.ToString(num1, 2); // перевод в cтрочный бинарный вид (в строчный, чтобы определить кол-во цифр в числе)
            simvol1 = strbin1.Length; // количество символов в бинарном виде
            bin1 = int.Parse(strbin1); // снова перевод в числовой вид
        }

        int num2 = int.Parse(Console.ReadLine()); // ввод второго числа

        // определение знака второго числа и перевод в бинарный вид
        if (num2 < 0)
        {
            int modnum2 = Math.Abs(num2); // модуль
            string strmodbin2 = Convert.ToString(modnum2, 2); // в положит. строковой бинарный
            int simvolmod2 = strmodbin2.Length; // кол-во символов в положит. бинарном
            string strbin2 = Convert.ToString(num2, 2); // в отриц. строковой бинарный
            string lastbin2 = strbin2.Substring(strbin2.Length - (simvolmod2 + 1)); // отброс лишних единиц

            simvol2 = strbin2.Length; // кол-во символов в отриц. бинарном

            bin2 = int.Parse(lastbin2); // перевод в числовой
        }
        else
        {
            string strbin2 = Convert.ToString(num2, 2); // перевод в cтрочный бинарный вид (в строчный, чтобы определить кол-во цифр в числе)
            simvol2 = strbin2.Length; // количество символов в бинарном виде
            bin2 = int.Parse(strbin2); // снова перевод в числовой вид
        }

        int num3 = int.Parse(Console.ReadLine()); // ввод третьего числа

        // определение знака третьего числа и перевод в бинарный вид
        if (num3 < 0)
        {
            int modnum3 = Math.Abs(num3); // модуль
            string strmodbin3 = Convert.ToString(modnum3, 2); // в положит. строковой бинарный
            int simvolmod3 = strmodbin3.Length; // кол-во символов в положит. бинарном
            string strbin3 = Convert.ToString(num3, 2); // в отриц. строковой бинарный
            string lastbin3 = strbin3.Substring(strbin3.Length - (simvolmod3 + 1)); // отброс лишних единиц

            simvol3 = strbin3.Length; // кол-во символов в отриц. бинарном

            bin3 = int.Parse(lastbin3); // перевод в числовой
        }
        else
        {
            string strbin3 = Convert.ToString(num3, 2); // перевод в cтрочный бинарный вид
            simvol3 = strbin3.Length; // количество символов в бинарном виде
            bin3 = int.Parse(strbin3); // снова перевод в числовой вид
        }


        int otv = 0; // сборка итогового числа в битовом виде
        int mnozh = 1; // помощник сборки
        int skok = 0;

        double otvotv = 0; // итоговое число
        int step = 0;

        while (simvol1 > 0)
        {
            int nol = 0; // счетчик нулей
            int odin = 0; // счетчик единиц

            // отбор символов
            int bit1 = bin1 % 10;
            bin1 = bin1 / 10;

            int bit2 = bin2 % 10;
            bin2 = bin2 / 10;

            int bit3 = bin3 % 10;
            bin3 = bin3 / 10;

            // работа счётчиков
            if (bit1 == 0) nol++;
            else odin++;

            if (bit2 == 0) nol++;
            else odin++;

            if (bit3 == 0) nol++;
            else odin++;

            // определение какого символа больше всего
            if (nol > odin) skok = 0;
            else skok = 1;

            otv = otv + skok * mnozh;
            mnozh = mnozh * 10;

            simvol1 = simvol1 - 1;

            otvotv = otvotv + Math.Pow(2, step) * skok;

            step++;

        }
        Console.WriteLine($"Новое число {otvotv}");
        Console.WriteLine($"Битовой вид нового числа: {otv}");
    }
}