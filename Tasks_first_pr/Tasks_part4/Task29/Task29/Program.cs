using System;

static int Sum(params int[] numbers)
{
    int s = 0;
    foreach (int n in numbers) s += n;
    return s;
}

static double Average(params int[] numbers)
{
    if (numbers.Length == 0) return 0;
    return (double)Sum(numbers) / numbers.Length;
}

static long Factorial(int n)
{
    if (n < 0) throw new ArgumentException("n < 0");
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}

static int[] ReadInts()
{
    Console.Write("Числа через пробел: ");
    string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] nums = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
        nums[i] = int.Parse(parts[i]);
    return nums;
}

while (true)
{
    Console.Write("Команда (Help/Sum/Average/Factorial/Exit): ");
    string input = Console.ReadLine();

    if (!Enum.TryParse<Command>(input, true, out var cmd))
    {
        Console.WriteLine("Неизвестная команда");
        continue;
    }

    switch (cmd)
    {
        case Command.Help:
            Console.WriteLine("Sum 1 2 3 | Average 1 2 3 | Factorial 5 | Exit");
            break;
        case Command.Sum:
            Console.WriteLine($"Сумма: {Sum(ReadInts())}");
            break;
        case Command.Average:
            Console.WriteLine($"Среднее: {Average(ReadInts())}");
            break;
        case Command.Factorial:
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {Factorial(n)}");
            break;
        case Command.Exit:
            return;
    }
}

enum Command { Help, Sum, Average, Factorial, Exit }