using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        int bestVal = a[0], bestCount = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++) if (a[j] == a[i]) count++;
            if (count > bestCount) { bestCount = count; bestVal = a[i]; }
        }
        Console.WriteLine(bestVal);
        Console.WriteLine(bestCount);
    }
}