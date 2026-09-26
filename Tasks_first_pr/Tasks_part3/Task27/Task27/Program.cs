using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        int total = 0;
        for (int i = 0; i < n; i++) { a[i] = int.Parse(s[i]); total += a[i]; }
        int left = 0;
        for (int i = 0; i < n; i++)
        {
            int right = total - left - a[i];
            if (left == right) { Console.WriteLine(i); return; }
            left += a[i];
        }
        Console.WriteLine("Нет");
    }
}