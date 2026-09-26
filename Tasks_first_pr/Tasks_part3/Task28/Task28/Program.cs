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
        int maxSum = int.MinValue, maxRow = 0;
        for (int i = 0; i < m; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++) sum += mat[i, j];
            if (sum > maxSum) { maxSum = sum; maxRow = i; }
        }
        Console.WriteLine(maxRow);
        Console.WriteLine(maxSum);
    }
}