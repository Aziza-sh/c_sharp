using System;

static int SumToN(int n)
{
    if (n <= 0) return 0;
    return n + SumToN(n - 1);
}

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма 1..{n} = {SumToN(n)}");