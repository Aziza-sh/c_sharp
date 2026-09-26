using System;

static bool IsWeekend(DayOfWeekSimple day)
{
    return day == DayOfWeekSimple.Saturday || day == DayOfWeekSimple.Sunday;
}

Console.Write("День недели (Monday..Sunday): ");
if (Enum.TryParse<DayOfWeekSimple>(Console.ReadLine(), true, out var day))
    Console.WriteLine(IsWeekend(day) ? "Выходной" : "Рабочий день");
else
    Console.WriteLine("Неизвестный день");

enum DayOfWeekSimple
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}