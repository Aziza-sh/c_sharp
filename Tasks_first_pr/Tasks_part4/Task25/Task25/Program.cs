using System;

while (true)
{
    Console.WriteLine("1 — приветствие");
    Console.WriteLine("2 — текущая дата");
    Console.WriteLine("3 — сумма двух чисел");
    Console.WriteLine("0 — выход");
    Console.Write("Выбор: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Привет!");
            break;
        case "2":
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
            break;
        case "3":
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма: {a + b}");
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Неизвестная команда");
            break;
    }
    Console.WriteLine();
}