using System;

static int Factorial(int n)
{
    if (n < 0) throw new ArgumentException("n < 0");
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{n}! = {Factorial(n)}");