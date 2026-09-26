using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int min = int.Parse(s[0]);
        for (int i = 1; i < n; i++)
        {
            int v = int.Parse(s[i]);
            if (v < min) min = v;
        }
        Console.WriteLine(min);
    }
}