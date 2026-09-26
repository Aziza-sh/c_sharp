using System;

Console.WriteLine("Введите цель (рублей):");
int goal = Convert.ToInt32(Console.ReadLine());

int total = 0;
int count = 0;

while (total < goal)
{
    Console.WriteLine("Введите пополнение (рублей):");
    int deposit = Convert.ToInt32(Console.ReadLine());
    total = total + deposit;
    count = count + 1;
}

Console.WriteLine("Накоплено: " + total + " рублей.");
Console.WriteLine("Пополнений: " + count + ".");
