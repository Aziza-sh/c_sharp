using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        int max1 = a[0];
        for (int i = 1; i < n; i++) if (a[i] > max1) max1 = a[i];
        int max2 = 0;
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == max1) continue;
            if (!found || a[i] > max2) { max2 = a[i]; found = true; }
        }
        if (found) Console.WriteLine(max2);
        else Console.WriteLine("Нет второго максимума");
    }
}