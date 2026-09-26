using System;

static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

Console.Write("a = ");
int x = int.Parse(Console.ReadLine());
Console.Write("b = ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine($"До: x={x}, y={y}");
Swap(ref x, ref y);
Console.WriteLine($"После: x={x}, y={y}");