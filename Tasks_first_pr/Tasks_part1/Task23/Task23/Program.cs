using System;

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 20)
{
    Console.WriteLine("В диапазоне");
}
else
{
    Console.WriteLine("Вне диапазона");
}
