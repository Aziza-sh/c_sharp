using System;

Console.WriteLine("Введите длину прямоугольника (см):");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину прямоугольника (см):");
int width = Convert.ToInt32(Console.ReadLine());

int area = length * width;
int perimeter = 2 * (length + width);

Console.WriteLine("Площадь: " + area + " см ^ 2.");
Console.WriteLine("Периметр: " + perimeter + " см.");
