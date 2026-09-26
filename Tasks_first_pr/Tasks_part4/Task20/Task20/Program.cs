using System;

static void PrintArrayStatistics(int[] numbers)
{
    if (numbers.Length == 0)
    {
        Console.WriteLine("Массив пуст");
        return;
    }

    int Sum()
    {
        int s = 0;
        foreach (int n in numbers) s += n;
        return s;
    }

    double Avg() => (double)Sum() / numbers.Length;

    int Min()
    {
        int m = numbers[0];
        foreach (int n in numbers) if (n < m) m = n;
        return m;
    }

    int Max()
    {
        int m = numbers[0];
        foreach (int n in numbers) if (n > m) m = n;
        return m;
    }

    Console.WriteLine($"Длина: {numbers.Length}");
    Console.WriteLine($"Сумма: {Sum()}");
    Console.WriteLine($"Среднее: {Avg():F2}");
    Console.WriteLine($"Минимум: {Min()}");
    Console.WriteLine($"Максимум: {Max()}");
}

Console.Write("Массив через пробел: ");
string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] arr = new int[parts.Length];
for (int i = 0; i < parts.Length; i++)
    arr[i] = int.Parse(parts[i]);

PrintArrayStatistics(arr);