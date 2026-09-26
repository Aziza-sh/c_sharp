using System;

Console.WriteLine("Введите целое число (1-10):");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    Console.WriteLine(number + " x " + i + " = " + result);
}
