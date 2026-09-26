using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        int last = a[n - 1];
        for (int i = n - 1; i > 0; i--) a[i] = a[i - 1];
        a[0] = last;
        Console.WriteLine(string.Join(" ", a));
    }
}