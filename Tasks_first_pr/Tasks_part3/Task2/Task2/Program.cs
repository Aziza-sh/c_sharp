using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        for (int i = n - 1; i >= 0; i--) Console.Write(a[i] + (i == 0 ? "" : " "));
    }
}