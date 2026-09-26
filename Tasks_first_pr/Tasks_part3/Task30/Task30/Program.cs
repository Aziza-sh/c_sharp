using System;
class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[,] mat = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < n; j++) mat[i, j] = int.Parse(s[j]);
        }
        int[,] tr = new int[n, m];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                tr[j, i] = mat[i, j];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++) Console.Write(mat[i, j] + (j == n - 1 ? "" : " "));
            Console.WriteLine();
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++) Console.Write(tr[i, j] + (j == m - 1 ? "" : " "));
            Console.WriteLine();
        }
    }
}