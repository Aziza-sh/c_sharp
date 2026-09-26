using System;

static string GetTemperatureCategory(double t)
{
    return t switch
    {
        < 0 => "мороз",
        < 15 => "холодно",
        < 25 => "тепло",
        _ => "жарко"
    };
}

Console.Write("Температура: ");
double t = double.Parse(Console.ReadLine());
Console.WriteLine(GetTemperatureCategory(t));