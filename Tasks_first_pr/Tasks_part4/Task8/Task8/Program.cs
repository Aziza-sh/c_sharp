using System;

static void IncreaseByValue(int value) { value++; }
static void IncreaseByRef(ref int value) { value++; }

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

IncreaseByValue(a);
Console.WriteLine($"После IncreaseByValue: {a}"); 

IncreaseByRef(ref a);
Console.WriteLine($"После IncreaseByRef: {a}");   

