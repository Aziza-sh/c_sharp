using System;

Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine() ?? "";

Console.WriteLine("Привет, " + name + "!");
