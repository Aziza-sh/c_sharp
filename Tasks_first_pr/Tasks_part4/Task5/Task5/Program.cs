using System;

static string GetGrade(int score)
{
    if (score >= 90) return "Отлично"; // 90–100 — "Отлично"
    else if (score >= 75) return "Хорошо"; // 75–89  — "Хорошо"
    else if (score >= 60) return "Удовлетворительно"; // 60–74  — "Удовлетворительно"
    else return "Неудовлетворительно"; // 0–59   — "Неудовлетворительно"
}

Console.Write("Введите балл: ");
int score = int.Parse(Console.ReadLine());
Console.WriteLine(GetGrade(score));