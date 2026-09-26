// Приветствие пользователя
using System;

static void PrintGreeting(string name)
{
    Console.WriteLine($"Привет, {name}!");
}

Console.Write("Введите имя: ");
string userName = Console.ReadLine();

PrintGreeting(userName);
PrintGreeting("Гость");