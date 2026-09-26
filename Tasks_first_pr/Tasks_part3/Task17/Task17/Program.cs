using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        int minI = 0, maxI = 0;
        for (int i = 1; i < n; i++)
        {
            if (a[i] < a[minI]) minI = i;
            if (a[i] > a[maxI]) maxI = i;
        }
        int start = Math.Min(minI, maxI);
        int end = Math.Max(minI, maxI);
        int sum = 0;
        for (int i = start + 1; i < end; i++) sum += a[i];
        Console.WriteLine(sum);
    }
}