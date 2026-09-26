using System;

static string JoinWithSeparator(string separator, params string[] parts)
{
    if (parts.Length == 0) return "";
    string result = parts[0];
    for (int i = 1; i < parts.Length; i++)
        result += separator + parts[i];
    return result;
}

Console.WriteLine(JoinWithSeparator(" | ", "C#", "Java", "Python"));

Console.Write("Разделитель: ");
string sep = Console.ReadLine();
Console.Write("Слова через пробел: ");
string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(JoinWithSeparator(sep, words));