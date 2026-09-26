using System;

Console.WriteLine("Введите первое целое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int b = Convert.ToInt32(Console.ReadLine());

int sum = a + b;
int difference = a - b;
int product = a * b;

Console.WriteLine("Сумма: " + sum + ".");
Console.WriteLine("Разность: " + difference + ".");
Console.WriteLine("Произведение: " + product + ".");
