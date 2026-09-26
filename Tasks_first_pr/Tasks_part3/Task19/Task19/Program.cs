using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        int k = int.Parse(Console.ReadLine());
        k = ((k % n) + n) % n;
        int[] res = new int[n];
        for (int i = 0; i < n; i++) res[(i + k) % n] = a[i];
        Console.WriteLine(string.Join(" ", res));
    }
}