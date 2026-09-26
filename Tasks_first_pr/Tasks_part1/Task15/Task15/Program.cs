using System;

Console.WriteLine("Введите стоимость покупки:");
int price = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите имеющуюся сумму:");
int money = Convert.ToInt32(Console.ReadLine());

if (money >= price)
{
    int change = money - price;
    Console.WriteLine("Останется: " + change + " рублей.");
}
else
{
    int missing = price - money;
    Console.WriteLine("Не хватает: " + missing + " рублей.");
}
