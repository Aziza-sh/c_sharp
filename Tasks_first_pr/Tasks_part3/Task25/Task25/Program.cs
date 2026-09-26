using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        string[] s1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] A = new int[n1];
        for (int i = 0; i < n1; i++) A[i] = int.Parse(s1[i]);
        int n2 = int.Parse(Console.ReadLine());
        string[] s2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] B = new int[n2];
        for (int i = 0; i < n2; i++) B[i] = int.Parse(s2[i]);
        List<int> res = new List<int>();
        for (int i = 0; i < n1; i++)
        {
            bool inB = false;
            for (int j = 0; j < n2; j++) if (A[i] == B[j]) { inB = true; break; }
            if (inB && !res.Contains(A[i])) res.Add(A[i]);
        }
        Console.WriteLine(string.Join(" ", res));
    }
}