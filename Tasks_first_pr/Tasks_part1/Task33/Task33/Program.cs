using System;

Console.WriteLine("Введите слово:");
string word = Console.ReadLine() ?? "";

Console.WriteLine("Введите количество повторений N (1-10):");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(word);
}
