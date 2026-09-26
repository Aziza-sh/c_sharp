using System;

static int SumDigits(int number)
{
    number = Math.Abs(number);
    if (number < 10) return number;
    return (number % 10) + SumDigits(number / 10);
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр: {SumDigits(n)}");