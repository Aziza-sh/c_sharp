using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        Console.WriteLine(string.Join(" ", a));
        for (int i = 0; i < n; i++) if (a[i] < 0) a[i] = 0;
        Console.WriteLine(string.Join(" ", a));
    }
}