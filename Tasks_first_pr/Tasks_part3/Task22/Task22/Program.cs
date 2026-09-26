using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<int> res = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int v = int.Parse(s[i]);
            if (!res.Contains(v)) res.Add(v);
        }
        Console.WriteLine(string.Join(" ", res));
    }
}