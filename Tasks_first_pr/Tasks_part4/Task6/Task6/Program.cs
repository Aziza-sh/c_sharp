using System;

static bool TryDivide(double a, double b, out double result)
{
    if (b == 0)
    {
        result = 0;
        return false;
    }
    result = a / b;
    return true;
}

Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());

if (TryDivide(a, b, out double res))
    Console.WriteLine($"Результат: {res}");
else
    Console.WriteLine("Деление на ноль невозможно");