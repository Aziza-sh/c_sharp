using System;

static int MaxOfThree(int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}

Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine($"Максимум: {MaxOfThree(a, b, c)}");