using System;

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}
