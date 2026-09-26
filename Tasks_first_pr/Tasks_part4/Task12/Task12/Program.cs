using System;

static int Sum(params int[] numbers)
{
    int sum = 0;
    foreach (int n in numbers) sum += n;
    return sum;
}

Console.WriteLine(Sum());
Console.WriteLine(Sum(5));
Console.WriteLine(Sum(1, 2, 3));

Console.Write("Введите числа через пробел: ");
string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] nums = new int[parts.Length];
for (int i = 0; i < parts.Length; i++)
    nums[i] = int.Parse(parts[i]);

Console.WriteLine($"Сумма: {Sum(nums)}");