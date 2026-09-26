using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(s[i]);
        int maxSum = a[0], cur = a[0];
        int start = 0, end = 0, tempStart = 0;
        for (int i = 1; i < n; i++)
        {
            if (cur < 0) { cur = a[i]; tempStart = i; }
            else cur += a[i];
            if (cur > maxSum) { maxSum = cur; start = tempStart; end = i; }
        }
        Console.WriteLine(maxSum);
        for (int i = start; i <= end; i++) Console.Write(a[i] + (i == end ? "" : " "));
    }
}