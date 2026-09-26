using System;

static double Calculate(double a, double b, char operation)
{
    return operation switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => b == 0 ? throw new DivideByZeroException("Деление на ноль") : a / b,
        _ => throw new ArgumentException($"Неизвестная операция: {operation}")
    };
}

Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("Операция (+, -, *, /): ");
char op = char.Parse(Console.ReadLine());

try
{
    Console.WriteLine($"Результат: {Calculate(a, b, op)}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}