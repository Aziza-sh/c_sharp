using System;

// Для пустого набора возвращаем 0 — безопасное поведение
static double Average(params double[] values)
{
    if (values.Length == 0) return 0;
    double sum = 0;
    foreach (double v in values) sum += v;
    return sum / values.Length;
}

Console.WriteLine(Average(1, 2, 3, 4));
Console.WriteLine(Average());

Console.Write("Введите числа через пробел: ");
string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double[] nums = new double[parts.Length];
for (int i = 0; i < parts.Length; i++)
    nums[i] = double.Parse(parts[i]);

Console.WriteLine($"Среднее: {Average(nums)}");