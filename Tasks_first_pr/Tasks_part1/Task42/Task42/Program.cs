using System;

int count = 0;

Console.WriteLine("Введите число (-1 - завершить):");
int number = Convert.ToInt32(Console.ReadLine());

while (number != -1)
{
    count = count + 1;
    Console.WriteLine("Введите число (-1 - завершить):");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Количество значений: " + count + ".");
