using System;

static int ReadScore()
{
    bool IsValid(int value) => value >= 0 && value <= 100;

    int score;
    while (true)
    {
        Console.Write("Введите балл (0..100): ");
        if (int.TryParse(Console.ReadLine(), out score) && IsValid(score))
            return score;
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
    }
}

int score = ReadScore();
Console.WriteLine($"Принят балл: {score}");