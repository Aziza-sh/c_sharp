using System;

static bool IsEven(int number)
{
    return number % 2 == 0;
}

for (int i = 1; i <= 10; i++)
{
    string parity = IsEven(i) ? "чётное" : "нечётное";
    Console.WriteLine($"{i} — {parity}");
}