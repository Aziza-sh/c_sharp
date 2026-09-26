using System;

Console.WriteLine("Введите число от 1 до 5:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1 || number > 5)
{
    Console.WriteLine("Введите число от 1 до 5");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Принято: " + number + ".");
