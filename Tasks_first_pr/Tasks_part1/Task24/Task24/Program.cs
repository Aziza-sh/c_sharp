using System;

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 3 == 0 || number % 5 == 0)
{
    Console.WriteLine("Подходит");
}
else
{
    Console.WriteLine("Не подходит");
}
