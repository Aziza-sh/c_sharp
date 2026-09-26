using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        int index = int.Parse(Console.ReadLine());
        if (index < 0 || index >= n) { Console.WriteLine("Некорректный индекс"); return; }
        int[] res = new int[n - 1];
        int k = 0;
        for (int i = 0; i < n; i++) if (i != index) res[k++] = a[i];
        Console.WriteLine(string.Join(" ", res));
    }
}