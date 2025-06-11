using System.Linq;
public class Numbers
{
    public static void Main()
    {
        Console.WriteLine("Введите число:");
        string str = Console.ReadLine();
        str = String.Concat(str.OrderBy(c => c));
        Console.WriteLine($"Преобразование в наименьшее число: {str}");
    }
}