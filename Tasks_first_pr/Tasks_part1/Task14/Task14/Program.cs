using System;

Console.WriteLine("Введите результат теста (0-100):");
int score = Convert.ToInt32(Console.ReadLine());

if (score >= 60)
{
    Console.WriteLine("Зачёт");
}
else
{
    Console.WriteLine("Нужно потренироваться");
}
