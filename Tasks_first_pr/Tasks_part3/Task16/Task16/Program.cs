using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        bool ok = true;
        for (int i = 1; i < n; i++)
        {
            if (int.Parse(s[i]) < int.Parse(s[i - 1])) { ok = false; break; }
        }
        Console.WriteLine(ok ? "да" : "нет");
    }
}