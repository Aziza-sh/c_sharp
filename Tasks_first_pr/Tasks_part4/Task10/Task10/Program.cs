using System;

static void GetMinMax(int[] numbers, out int min, out int max)
{
    min = numbers[0];
    max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min) min = numbers[i];
        if (numbers[i] > max) max = numbers[i];
    }
}

Console.Write("Введите числа через пробел: ");
string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] data = new int[parts.Length];
for (int i = 0; i < parts.Length; i++)
    data[i] = int.Parse(parts[i]);

GetMinMax(data, out int min, out int max);
Console.WriteLine($"min={min}, max={max}");