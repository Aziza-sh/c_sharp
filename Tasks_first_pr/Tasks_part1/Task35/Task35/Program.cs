using System;

Console.WriteLine("Введите N (1-1000):");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum = sum + i;
}

Console.WriteLine("Сумма: " + sum + ".");
