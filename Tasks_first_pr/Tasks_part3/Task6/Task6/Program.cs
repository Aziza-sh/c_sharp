using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int max = int.Parse(s[0]);
        int index = 0;
        for (int i = 1; i < n; i++)
        {
            int v = int.Parse(s[i]);
            if (v > max) { max = v; index = i; }
        }
        Console.WriteLine(max);
        Console.WriteLine(index);
    }
}