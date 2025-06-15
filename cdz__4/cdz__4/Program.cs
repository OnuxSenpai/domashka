using System;
using System.Diagnostics;
class Test
{
    static void Main()
    {
        List<string> questions = new List<string>(); // новый список из вопросов
        questions.Add("Вопрос 1: С каким языком программирования было знакомство в этом семестре?");
        questions.Add("Вопрос 2: Что такое консоль в C#?");
        questions.Add("Вопрос 3: Какой тип данных используется для хранения логических значений (истина/ложь) в C#?");
        questions.Add("Вопрос 4: Что такое такое метод в C#?");
        questions.Add("Вопрос 5: Что делает оператор + в C#, если он используется с двумя строками?");

        List<List<string>> ans = new List<List<string>>(); // новый список из списков ответов

        List<string> ans1 = new List<string>(); // список из ответов на первый вопрос
        ans1.Add("1. C#");
        ans1.Add("2. Python");
        ans1.Add("3. Java");
        ans1.Add("4. JavaScript");
        ans.Add(ans1); // присваиваем список к основному списку с вопросами

        // далее тот же алгоритм
        List<string> ans2 = new List<string>();
        ans2.Add("1. Графический интерфейс пользователя.");
        ans2.Add("2. Текстовый интерфейс для ввода и вывода.");
        ans2.Add("3. Интерфейс для выполнения команд OC.");
        ans2.Add("4. Класс для работы с базами данных.");
        ans.Add(ans2);

        List<string> ans3 = new List<string>();
        ans3.Add("1. string");
        ans3.Add("2. int");
        ans3.Add("3. bool");
        ans3.Add("4. char");
        ans.Add(ans3);

        List<string> ans4 = new List<string>();
        ans4.Add("1. Тим данных для хранения текста.");
        ans4.Add("2. Ключевое слово для объявления переменной.");
        ans4.Add("3. Комментарий в коде.");
        ans4.Add("4. Набор инструкций, выполняющих определённую задачую");
        ans.Add(ans4);

        List<string> ans5 = new List<string>();
        ans5.Add("1. Объединяет строки в одну строку.");
        ans5.Add("2. Складывает строки как числа.");
        ans5.Add("3. Сравнивает строки.");
        ans5.Add("4. Выдаёт ошибк.у");
        ans.Add(ans5);

        List<int> correctans = new List<int>(); // список из правильных ответов

        // отречить комменты
        correctans.Add(0); // Правильный ответ на первый вопрос - вариант 1 (C#)
        correctans.Add(1); // Правильный ответ на второй вопрос - вариант 1 (место в памяти)
        correctans.Add(2); // Правильный ответ на третий вопрос - вариант 3 (инструкция для повторения)
        correctans.Add(3);
        correctans.Add(0);


        int score = 0; // счетчик правильных ответов


        Stopwatch time = new Stopwatch();
        time.Start();


        for (int i = 0; i < questions.Count; i++) //(questions.Count - кол-во элементов в массиве из вопросов)
        {
            Console.Clear(); // чистка консоли перед выводом вопроса с ответами
            Console.WriteLine(questions[i]);

            // вывод вариантов ответа на вопрос (ans[i].Count - кол-во элементов в массиве вопросов)
            for (int j = 0; j < ans[i].Count; j++) {Console.WriteLine(ans[i][j]);}
            
            Console.Write("Введите выбранный вами номер варианта ответа): ");
            string otv = Console.ReadLine();
            int userAnswer = Convert.ToInt32(otv);

            // проверка правильности ответа
            if (userAnswer - 1 == correctans[i]) {score++;}
        }

        time.Stop();
        TimeSpan elapsedTime = time.Elapsed;


        Console.Clear(); // чистка консоли
        Console.WriteLine($"Вы ответили правильно на {score} из 5 вопросов.");

        // результаты теста (тест пройден, если все ответы на вопросы верны)
        if (score == questions.Count) {Console.WriteLine("Результат теста: пройден.");}
        else {Console.WriteLine("Результат теста: не пройден.");}

        Console.WriteLine($"Время выполнения теста: {elapsedTime.Minutes} минут {elapsedTime.Seconds} секунд");
    }
}