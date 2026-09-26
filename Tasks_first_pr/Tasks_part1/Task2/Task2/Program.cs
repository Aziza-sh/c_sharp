using System;

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int previous = number - 1;
int next = number + 1;

Console.WriteLine("Предыдущее: " + previous + ".");
Console.WriteLine("Следующее: " + next + ".");
