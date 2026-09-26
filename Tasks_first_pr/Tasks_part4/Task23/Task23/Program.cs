using System;

static int DaysInMonth(int month, bool isLeapYear)
{
    return month switch
    {
        1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
        4 or 6 or 9 or 11 => 30,
        2 => isLeapYear ? 29 : 28,
        _ => throw new ArgumentOutOfRangeException(nameof(month)) // Исключение „аргумент вне диапазона“
    };
}

Console.Write("Месяц (1..12): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Високосный год? (y/n): ");
bool leap = Console.ReadLine().Trim().ToLower() == "y";

try
{
    Console.WriteLine($"Дней: {DaysInMonth(m, leap)}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}