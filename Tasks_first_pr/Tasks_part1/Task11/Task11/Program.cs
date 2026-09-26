using System;

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Положительное");
}
else
{
    Console.WriteLine("Неположительное");
}
