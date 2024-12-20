using System.Text.RegularExpressions;

/// <summary>
/// Класс StringHelper предоставляет вспомогательные методы для работы со строками.
/// </summary>
public class StringHelper
{
    /// <summary>
    /// Возвращает перевернутую строку.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    /// <returns>Перевернутая строка.</returns>
    /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
    public string ReverseString(string str)
    {
        if (str == null)
            throw new ArgumentNullException(nameof(str), "Строка не должна быть null.");

        return new string(str.Reverse().ToArray());
    }

    /// <summary>
    /// Возвращает количество слов в строке.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    /// <returns>Количество слов в строке.</returns>
    /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
    public int CountWords(string str)
    {
        if (str == null)
            throw new ArgumentNullException(nameof(str), "Строка не должна быть null.");

        return str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    /// <summary>
    /// Проверяет, является ли строка палиндромом.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    /// <returns>True, если строка является палиндромом; иначе False.</returns>
    /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
    public bool IsPalindrome(string str)
    {
        if (str == null)
            throw new ArgumentNullException(nameof(str), "Строка не должна быть null.");

        var sanitized = Regex.Replace(str, "[\\W_]+", "").ToLower();
        return sanitized.SequenceEqual(sanitized.Reverse());
    }

    /// <summary>
    /// Возвращает строку с заглавной первой буквой.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    /// <returns>Строка с заглавной первой буквой.</returns>
    /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
    public string CapitalizeFirstLetter(string str)
    {
        if (str == null)
            throw new ArgumentNullException(nameof(str), "Строка не должна быть null.");

        if (str.Length == 0)
            return str;

        return char.ToUpper(str[0]) + str.Substring(1);
    }
}

/// <summary>
/// Точка входа в программу.
/// </summary>
public class Program
{
    public static void Main()
    {
        var helper = new StringHelper();

        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        Console.WriteLine("Результаты:");
        Console.WriteLine($"Перевернутая строка: {helper.ReverseString(input)}");
        Console.WriteLine($"Количество слов: {helper.CountWords(input)}");
        Console.WriteLine($"Является ли палиндромом: {helper.IsPalindrome(input)}");
        Console.WriteLine($"С заглавной первой буквой: {helper.CapitalizeFirstLetter(input)}");
    }
}
