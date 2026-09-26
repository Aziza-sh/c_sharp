using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int v = int.Parse(s[i]);
            if (v % 2 == 0)
            {
                Console.Write(v + " ");
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(count);
    }
}