using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] mat = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < n; j++) mat[i, j] = int.Parse(s[j]);
        }
        int mainSum = 0, secSum = 0;
        for (int i = 0; i < n; i++)
        {
            mainSum += mat[i, i];
            secSum += mat[i, n - 1 - i];
        }
        Console.WriteLine(mainSum);
        Console.WriteLine(secSum);
    }
}