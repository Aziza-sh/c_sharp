using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        for (int i = 0; i < n; i++) if (int.Parse(s[i]) > 0) count++;
        Console.WriteLine(count);
    }
}