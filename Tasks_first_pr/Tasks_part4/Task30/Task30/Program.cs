using System;

static GradeCategory GetCategory(int score)
{
    return score switch
    {
        >= 90 => GradeCategory.Excellent,
        >= 75 => GradeCategory.Good,
        >= 60 => GradeCategory.Satisfactory,
        _ => GradeCategory.Unsatisfactory
    };
}

static void GetMinMax(int[] scores, out int min, out int max)
{
    min = max = scores[0];
    for (int i = 1; i < scores.Length; i++)
    {
        if (scores[i] < min) min = scores[i];
        if (scores[i] > max) max = scores[i];
    }
}

static double Average(params int[] scores)
{
    if (scores.Length == 0) return 0;
    int s = 0;
    foreach (int x in scores) s += x;
    return (double)s / scores.Length;
}

static void NormalizeScore(ref int score)
{
    if (score < 0) score = 0;
    else if (score > 100) score = 100;
}

static int CountAboveRecursive(int[] scores, int threshold, int index = 0)
{
    if (index >= scores.Length) return 0;
    int add = scores[index] > threshold ? 1 : 0;
    return add + CountAboveRecursive(scores, threshold, index + 1);
}

bool IsValidInput(string s, out int value) => int.TryParse(s, out value);

Console.Write("Сколько оценок? ");
int count = int.Parse(Console.ReadLine());
int[] scores = new int[count];

for (int i = 0; i < count; i++)
{
    int val;
    while (true)
    {
        Console.Write($"Оценка {i + 1}: ");
        if (IsValidInput(Console.ReadLine(), out val)) break;
        Console.WriteLine("Некорректный ввод");
    }
    NormalizeScore(ref val);
    scores[i] = val;
}

GetMinMax(scores, out int min, out int max);
Console.WriteLine($"Длина: {scores.Length}");
Console.WriteLine($"Мин: {min}, Макс: {max}");
Console.WriteLine($"Среднее: {Average(scores):F2}");

Console.Write("Порог: ");
int threshold = int.Parse(Console.ReadLine());
Console.WriteLine($"Выше порога: {CountAboveRecursive(scores, threshold)}");

foreach (int s in scores)
    Console.WriteLine($"{s} — {GetCategory(s)}");

enum GradeCategory { Excellent, Good, Satisfactory, Unsatisfactory }