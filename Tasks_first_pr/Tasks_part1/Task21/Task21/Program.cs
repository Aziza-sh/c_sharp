using System;

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Положительное");
}
else if (number < 0)
{
    Console.WriteLine("Отрицательное");
}
else
{
    Console.WriteLine("Ноль");
}
