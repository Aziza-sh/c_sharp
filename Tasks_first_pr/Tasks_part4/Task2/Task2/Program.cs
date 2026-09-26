using System;

static double CalculateRectangleArea(double width, double height)
{
    return width * height;
}

Console.Write("Ширина: ");
double w = double.Parse(Console.ReadLine());
Console.Write("Высота: ");
double h = double.Parse(Console.ReadLine());

Console.WriteLine($"Площадь: {CalculateRectangleArea(w, h)}");
Console.WriteLine(CalculateRectangleArea(5, 3));
Console.WriteLine(CalculateRectangleArea(2.5, 4));
Console.WriteLine(CalculateRectangleArea(0, 10));