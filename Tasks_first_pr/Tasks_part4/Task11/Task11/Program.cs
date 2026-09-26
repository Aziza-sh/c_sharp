using System;

static void Clamp(ref int value, int min, int max)
{
    if (value < min) value = min;
    else if (value > max) value = max;
}

Console.Write("Введите число: ");
int v = int.Parse(Console.ReadLine());

Clamp(ref v, 0, 100);
Console.WriteLine($"После Clamp(0..100): {v}");