using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int x = int.Parse(Console.ReadLine());
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            if (int.Parse(s[i]) == x) { index = i; break; }
        }
        if (index != -1) Console.WriteLine(index);
        else Console.WriteLine("Не найдено");
    }
}