using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        for (int i = 0; i < n / 2; i++)
        {
            int t = a[i]; a[i] = a[n - 1 - i]; a[n - 1 - i] = t;
        }
        Console.WriteLine(string.Join(" ", a));
    }
}