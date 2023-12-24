using System;
using System.Text.RegularExpressions;


// Найти в строке с текстом подстроку с числами (такая подстрока всего одна).
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку с текстом:");
        var text = Console.ReadLine();

        var numbersSubstring = FindNumbersSubstring(text);
        Console.WriteLine($"Подстрока с числами: {numbersSubstring}");
    }

    static string FindNumbersSubstring(string text)
    {
        // Используем регулярное выражение для поиска подстроки с числами
        var pattern = @"\d+";
        Match match = Regex.Match(text, pattern);

        // Если найдено совпадение, возвращаем найденную подстроку
        if (match.Success)
        {
            return match.Value;
        }

        // Если совпадение не найдено, возвращаем пустую строку
        return string.Empty;
    }
}