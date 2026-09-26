using System;

static bool Contains(int[] array, int value, int index = 0)
{
    if (index >= array.Length) return false;
    if (array[index] == value) return true;
    return Contains(array, value, index + 1);
}

Console.Write("Массив через пробел: ");
string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] arr = new int[parts.Length];
for (int i = 0; i < parts.Length; i++)
    arr[i] = int.Parse(parts[i]);

Console.Write("Что ищем: ");
int value = int.Parse(Console.ReadLine());

Console.WriteLine(Contains(arr, value) ? "Найдено" : "Не найдено");