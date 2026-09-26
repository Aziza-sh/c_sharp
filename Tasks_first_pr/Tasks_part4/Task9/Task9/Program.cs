using System;

static bool TryReadInt(string text, out int number)
{
    return int.TryParse(text, out number);
}

Console.Write("Введите число: ");
string input = Console.ReadLine();

if (TryReadInt(input, out int n))
    Console.WriteLine($"Вы ввели: {n}");
else
    Console.WriteLine("Это не целое число");