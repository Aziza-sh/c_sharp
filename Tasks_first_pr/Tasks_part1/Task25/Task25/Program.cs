using System;

Console.WriteLine("Введите результат (0-100 баллов):");
int score = Convert.ToInt32(Console.ReadLine());

if (score < 50)
{
    Console.WriteLine("Оценка: 2");
}
else if (score < 70)
{
    Console.WriteLine("Оценка: 3");
}
else if (score < 90)
{
    Console.WriteLine("Оценка: 4");
}
else
{
    Console.WriteLine("Оценка: 5");
}
