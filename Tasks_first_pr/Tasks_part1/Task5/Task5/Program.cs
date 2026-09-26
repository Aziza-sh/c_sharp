using System;

const int notebookPrice = 50;
const int penPrice = 20;

Console.WriteLine("Введите количество тетрадей:");
int notebooks = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество ручек:");
int pens = Convert.ToInt32(Console.ReadLine());

int total = notebooks * notebookPrice + pens * penPrice;

Console.WriteLine("Стоимость: " + total + " рублей.");
