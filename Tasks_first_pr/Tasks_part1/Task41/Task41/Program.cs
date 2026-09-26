using System;

int sum = 0;

Console.WriteLine("Введите число (0 - завершить):");
int number = Convert.ToInt32(Console.ReadLine());

while (number != 0)
{
    sum = sum + number;
    Console.WriteLine("Введите число (0 - завершить):");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Сумма: " + sum + ".");
