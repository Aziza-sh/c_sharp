using System;

Console.WriteLine("Введите первое целое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое больше");
}
else if (b > a)
{
    Console.WriteLine("Второе больше");
}
else
{
    Console.WriteLine("Числа равны");
}
